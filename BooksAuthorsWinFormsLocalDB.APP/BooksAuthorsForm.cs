using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksAuthorsWinFormsLocalDB.Services;
using BooksAuthorsWinFormsLocalDB.DAL;

namespace BooksAuthorsWinFormsLocalDB.APP
{
    public partial class BooksAuthorsForm : Form
    {
        Authors toEditAuthor;
        Books toEditBook;
        BindingList<Authors> authors;
        BindingList<PublishingHouses> publishers;

        AuthorRepository authorRepository;
        PublisherRepository publisherRepository;

        public BooksAuthorsForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeRepositories();
            LoadLocalData();
            BindDataSources();
            RefreshViews();
            saveToolStripMenuItem.Enabled = authors.Count != 0;
        }

        private void BindDataSources()
        {
            publishersBindingSource.DataSource = publishers;
            authorsBindingSource.DataSource = authors;

            publisherDropdownColumn.DataSource = publishersBindingSource;
            booksBindingSource.DataSource = authorsBindingSource;
            booksBindingSource.DataMember = "Books";
        }

        private void LoadLocalData()
        {
            publishers = publisherRepository.GetAllLocal();
            authors = authorRepository.GetAllLocal();
            AddNewAuthorIfEmpty();
        }

        private void AddNewAuthorIfEmpty()
        {
            if (authors.Count == 0)
            {
                authors.Add(new Authors());
                authorsDataGridView.AllowUserToAddRows = false;
            }

            else
            {
                authorsDataGridView.AllowUserToAddRows = true;
            }
        }

        private void InitializeRepositories()
        {
            authorRepository = new AuthorRepository();
            publisherRepository = new PublisherRepository();
        }

        private void booksDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.Cells["publisherDropdownColumn"].Value == null)
            {
                var publisher = publishers.FirstOrDefault();
                if (publisher != null)
                {
                    e.Row.Cells["publisherDropdownColumn"].Value = publisher.Id;
                }
            }
        }

        private void RefreshViews()
        {
            authorsDataGridView.Refresh();
            booksDataGridView.Refresh();
        }

        private void LoadData()
        {
            publishers = publisherRepository.GetAll();
            authors = authorRepository.GetAll();
            AddNewAuthorIfEmpty();
        }

        private void authorsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (authorsDataGridView.Columns[e.ColumnIndex].Name == "firstNameDataGridViewTextBoxColumn" || authorsDataGridView.Columns[e.ColumnIndex].Name == "lastNameDataGridViewTextBoxColumn")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = $"{authorsDataGridView.Columns[e.ColumnIndex].HeaderText} Cannot be empty";
                }

                else if (e.FormattedValue.ToString().Length < 2)
                {
                    e.Cancel = true;
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = $"{authorsDataGridView.Columns[e.ColumnIndex].HeaderText} is too short";
                }

                else if (e.FormattedValue.ToString().Length > 30)
                {
                    e.Cancel = true;
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = $"{authorsDataGridView.Columns[e.ColumnIndex].HeaderText} is too long";
                }

                else
                {
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void authorsDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            authorsDataGridView.Rows[e.RowIndex].ErrorText = "";
            authorsDataGridView.AllowUserToAddRows = true;
            //saveToolStripMenuItem.Enabled = true;
        }

        private void booksDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            saveToolStripMenuItem.Enabled = false;
            if (booksDataGridView.Columns[e.ColumnIndex].Name == "titleDataGridViewTextBoxColumn")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    booksDataGridView.Rows[e.RowIndex].ErrorText = $"{booksDataGridView.Columns[e.ColumnIndex].HeaderText} cannot be empty";
                }

                else if (e.FormattedValue.ToString().Length < 5)
                {
                    e.Cancel = true;
                    booksDataGridView.Rows[e.RowIndex].ErrorText = $"{booksDataGridView.Columns[e.ColumnIndex].HeaderText} is too short";
                }

                else if (e.FormattedValue.ToString().Length > 255)
                {
                    e.Cancel = true;
                    booksDataGridView.Rows[e.RowIndex].ErrorText = $"{booksDataGridView.Columns[e.ColumnIndex].HeaderText} is too long";
                }

                else
                {
                    booksDataGridView.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void authorsDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (authorsDataGridView.Rows[e.RowIndex].DataBoundItem != null)
                {
                    booksDataGridView.AllowUserToAddRows = publishers.Count != 0;
                    toEditAuthor = authorsDataGridView.Rows[e.RowIndex].DataBoundItem as Authors;
                }

                if (authorsDataGridView.Rows[e.RowIndex].IsNewRow)
                {
                    addNewAuthorToolStripMenuItem.Enabled = false;
                    booksDataGridView.AllowUserToAddRows = false;
                }

                else
                {
                    addNewAuthorToolStripMenuItem.Enabled = true;
                    booksDataGridView.AllowUserToAddRows = true;
                }
            }

            catch
            {
                authorsDataGridView.EndEdit();
            }
        }

        private void booksDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            booksDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void authorsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            authorsDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void booksDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            booksDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void booksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            booksDataGridView.AllowUserToAddRows = publishers.Count != 0;
        }

        private void authorsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (authorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "firstNameDataGridViewTextBoxColumn")
            {
                if (authorsDataGridView.Rows[e.RowIndex].Cells["lastNameDataGridViewTextBoxColumn"].Value == null)
                {
                    e.Cancel = true;
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = "Last Name is Required";

                }

                else
                {
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = null;
                }
            }

            if (authorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "lastNameDataGridViewTextBoxColumn")
            {
                if (authorsDataGridView.Rows[e.RowIndex].Cells["firstNameDataGridViewTextBoxColumn"].Value == null)
                {
                    e.Cancel = true;
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = "First Name is Required";
                }

                else
                {
                    authorsDataGridView.Rows[e.RowIndex].ErrorText = null;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                authorRepository.Save();
                LoadData();
                BindDataSources();
                RefreshViews();
                MessageBox.Show("Saved");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                authorsDataGridView.EndEdit();
                booksDataGridView.EndEdit();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                authorsDataGridView.EndEdit();
                booksDataGridView.EndEdit();
                authorRepository.ResetDb();
                authorRepository.Reset();
                LoadData();
                BindDataSources();
                RefreshViews();
            }

            catch
            {
                authorsDataGridView.EndEdit();
                booksDataGridView.EndEdit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!authorsDataGridView.CurrentCell.OwningRow.IsNewRow)
            {
                var author = new Authors();
                AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(author);
                addEditAuthorForm.ShowDialog();
                if (addEditAuthorForm.DialogResult == DialogResult.OK)
                {
                    authors.Add(author);
                }
            }
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var publisherForm = new PublisherForm(ref publishersBindingSource);
            publisherForm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                authorRepository.Reset();
                LoadData();
                BindDataSources();
                RefreshViews();
                saveToolStripMenuItem.Enabled = false;
            }

            catch
            {
                authorsDataGridView.EndEdit();
                booksDataGridView.EndEdit();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toEditAuthor != null)
            {
                AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(toEditAuthor);
                addEditAuthorForm.ShowDialog();
                RefreshViews();
            }
        }

        private void authorsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (authorsDataGridView.CurrentCell.OwningRow.DataBoundItem as Authors != null)
                {
                    authorsDataGridView.ClearSelection();
                    authorsDataGridView.Rows[e.RowIndex].Selected = true;
                    authorsDataGridView.CurrentCell = authorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    toEditAuthor = authorsDataGridView.Rows[e.RowIndex].DataBoundItem as Authors;
                }
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toEditAuthor != null)
            {
                var book = new Books();
                AddEditBookForm addEditBookForm = new AddEditBookForm(book, publishers);
                addEditBookForm.ShowDialog();
                if (addEditBookForm.DialogResult == DialogResult.OK)
                {
                    toEditAuthor.Books.Add(book);
                }
            }

            //BindDataSources();
        }

        private void authorsMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            switch (toEditAuthor)
            {
                case null:
                    authorsMenuStrip.Items[0].Enabled = false;
                    authorsMenuStrip.Items[1].Enabled = false;
                    authorsMenuStrip.Items[2].Enabled = false;
                    break;
                default:
                    authorsMenuStrip.Items[0].Enabled = true;
                    authorsMenuStrip.Items[1].Enabled = true;
                    authorsMenuStrip.Items[2].Enabled = true;
                    break;
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toEditBook != null)
            {
                AddEditBookForm addEditBookForm = new AddEditBookForm(toEditBook, publishers);
                addEditBookForm.ShowDialog();
                RefreshViews();
            }
        }

        private void booksMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (!booksDataGridView.AllowUserToAddRows)
            {
                e.Cancel = true;
            }

            else
            {
                switch (toEditBook)
                {
                    case null:
                        booksMenuStrip.Items[0].Enabled = false;
                        break;
                    default:
                        booksMenuStrip.Items[0].Enabled = true;
                        break;
                }
            }
        }

        private void booksDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (booksDataGridView.CurrentCell != null && e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                if (booksDataGridView.CurrentCell.OwningRow.DataBoundItem as Books != null)
                {
                    booksDataGridView.ClearSelection();
                    booksDataGridView.Rows[e.RowIndex].Selected = true;
                    booksDataGridView.CurrentCell = booksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    toEditBook = booksDataGridView.Rows[e.RowIndex].DataBoundItem as Books;
                }
            }
        }

        private void showBooksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toEditAuthor != null)
            {
                var booksAuthorsReportForm = new BooksAuthorsReportForm(toEditAuthor);
                booksAuthorsReportForm.ShowDialog();
            }
        }

        private void authorsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            saveToolStripMenuItem.Enabled = false;
            resetToolStripMenuItem.Enabled = false;
            refreshToolStripMenuItem.Enabled = false;
        }

        private void authorsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            resetToolStripMenuItem.Enabled = true;
            refreshToolStripMenuItem.Enabled = true;
            booksDataGridView.AllowUserToAddRows = true;
        }

        private void booksDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            resetToolStripMenuItem.Enabled = true;
            refreshToolStripMenuItem.Enabled = true;
        }

        private void booksDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            saveToolStripMenuItem.Enabled = false;
            resetToolStripMenuItem.Enabled = false;
            refreshToolStripMenuItem.Enabled = false;
        }

        private void booksDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}
