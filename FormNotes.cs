using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Manager
{
    public partial class FormNotes : Form
    {
        private string _notesPath;
        private string _notesDir;
        private List<Note> _notes;
        private BindingList<Note> _bindingNotes;
        private readonly BindingSource bindingSourceNotes = new BindingSource();

        private Note _selectedNote;

        #region Event Handlers
        public event EventHandler<SelectedNoteChangedEventArgs> SelectedNoteChanged;
        protected virtual void OnSelectedNoteChanged(SelectedNoteChangedEventArgs e)
        {
            EventHandler<SelectedNoteChangedEventArgs> handler = SelectedNoteChanged;
            handler?.Invoke(this, e);
        }

        public event EventHandler<NoteListChangedEventArgs> NoteListChanged;
        protected virtual void OnNoteListChanged(NoteListChangedEventArgs e)
        {
            EventHandler<NoteListChangedEventArgs> handler = NoteListChanged;
            handler?.Invoke(this, e);
        }
        #endregion

        public FormNotes()
        {
            InitializeComponent();
            CenterToParent();
        }

        public FormNotes(string path, string dir) : this()
        {
            _notesPath = path;
            _notesDir = dir;
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            LoadNotes();
            UpdateUI();
            listboxNotes.SelectedIndexChanged += ListboxNotes_SelectedIndexChanged;
            SelectedNoteChanged += FormNotes_SelectedNoteChanged;
            NoteListChanged += FormNotes_NoteListChanged;
        }

        private void FormNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveNotes();
        }

        private void FormNotes_NoteListChanged(object sender, NoteListChangedEventArgs e)
        {
            _bindingNotes = e.NewList;
            ReloadNotes(_bindingNotes);
        }

        private void FormNotes_SelectedNoteChanged(object sender, SelectedNoteChangedEventArgs e)
        {
            if(e.Note == null)
            {
                txtTitle.Text = string.Empty;
                txtBody.Text = string.Empty;
                btnSaveClose.Tag = btnSave.Tag = btnDelete.Tag = null;
            }
            else
            {
                _selectedNote = e.Note;
                txtTitle.Text = _selectedNote.Title;
                txtBody.Text = _selectedNote.Body;
                btnDelete.Tag = btnSave.Tag = btnSaveClose.Tag = _selectedNote;
            }
        }

        private void ListboxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedNoteChanged(new SelectedNoteChangedEventArgs(listboxNotes.SelectedItem as Note));
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var newNote = new Note()
            {
                Title = "New Note",
                Body = "",
                CreatedOn = DateTime.Now
            };

            _bindingNotes.Add(newNote);
            ReloadNotes(_bindingNotes);
            listboxNotes.SelectedIndex = _bindingNotes.IndexOf(newNote);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Note selectedNote = ((Button)sender).Tag as Note;
            if (selectedNote == null)
            {
                MessageBox.Show("Please select a note to delete.");
                return;
            }
            selectedNote.IsArchived = true;

            var item = _bindingNotes.Select((Item, Index) => new { Item, Index }).FirstOrDefault(x => x.Item.CreatedOn == selectedNote.CreatedOn);
            if (item != null)
            {
                _bindingNotes[item.Index] = selectedNote;
            }
            ReloadNotes(_bindingNotes);

            MessageBox.Show($"Successfully removed '{selectedNote.Title}'");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Note selectedNote = ((Button)sender).Tag as Note;
            if (selectedNote == null)
            {
                MessageBox.Show("Cannot save nothing. Please create a new note, or update an existing one.");
                return;
            }

            selectedNote.Title = txtTitle.Text;
            selectedNote.Body = txtBody.Text;

            var item = _bindingNotes.Select((Item, Index) => new { Item, Index }).FirstOrDefault(x => x.Item.CreatedOn == selectedNote.CreatedOn);
            if (item != null)
            {
                _bindingNotes[item.Index] = selectedNote;
            }
            ReloadNotes(_bindingNotes);

            if (((Button)sender).Text.Contains("Close"))
            {
                this.Close();
            }
        }

        private void TxtTitle_Click(object sender, EventArgs e)
        {
            txtTitle.SelectAll();
        }

        private void ReloadNotes(BindingList<Note> list)
        {
            if(list.Count == 0)
            {
                list.Add(new Note()
                {
                    Title = "No Notes Found",
                    Body = "Click the New Note button below to create a new note, or update this one.",
                    CreatedOn = DateTime.Now
                });
            }

            BindingList<Note> cleanNotes = new BindingList<Note>();
            foreach(var item in list)
            {
                if (item.IsArchived == false)
                {
                    cleanNotes.Add(item);
                }
            }

            ResetNoteSource(cleanNotes);
        }

        private void ResetNoteSource(BindingList<Note> list)
        {
            bindingSourceNotes.DataSource = list.OrderBy(x => x.Title);
            listboxNotes.DataSource = bindingSourceNotes;
            listboxNotes.DisplayMember = "Title";

            listboxNotes.SelectedIndex = 0;
        }

        private void LoadNotes()
        {
            _bindingNotes = new BindingList<Note>();
            if (File.Exists(_notesPath))
            {
                using (StreamReader r = new StreamReader(File.OpenRead(_notesPath)))
                {
                    string json = r.ReadToEnd();
                    _notes = JsonConvert.DeserializeObject<ProjectNote>(json).Notes;
                }

                foreach(Note note in _notes)
                {
                    if (note.IsArchived) { continue; }
                    _bindingNotes.Add(note);
                }
            }

            ReloadNotes(_bindingNotes);
        }

        private void SaveNotes()
        {
            if (!Directory.Exists(_notesDir))
            {
                Directory.CreateDirectory(_notesDir);
            }

            if (!File.Exists(_notesPath))
            {
                File.Create(_notesPath).Dispose();
            }

            ProjectNote projNote = new ProjectNote();
            projNote.Notes = new List<Note>();

            foreach(Note n in _bindingNotes)
            {
                projNote.Notes.Add(n);
            }

            string jsonOut = JsonConvert.SerializeObject(projNote);
            File.WriteAllText(_notesPath, jsonOut);
        }

        private void UpdateUI()
        {
            Note selectedNote = listboxNotes.SelectedItem as Note;
            txtTitle.Text = selectedNote.Title;
            txtBody.Text = selectedNote.Body;
        }
    }

    public class SelectedNoteChangedEventArgs : EventArgs
    {
        public Note Note { get; set; }

        public SelectedNoteChangedEventArgs(Note note)
        {
            Note = note;
        }
    }

    public class NoteListChangedEventArgs : EventArgs
    {
        public BindingList<Note> NewList { get; set; }

        public NoteListChangedEventArgs(BindingList<Note> newList)
        {
            NewList = newList;
        }
    }
}
