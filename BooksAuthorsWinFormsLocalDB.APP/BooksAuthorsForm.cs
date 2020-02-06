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
        BindingList<Books> books;
        BindingList<Authors> authors;
        BindingList<PublishingHouses> publishers;

        AuthorRepository authorRepository;
        BookRepository bookRepository;
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
        }

        private void InitializeRepositories()
        {
            authorRepository = new AuthorRepository();
            bookRepository = new BookRepository();
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

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            authorRepository.Save();
            LoadData();
            BindDataSources();
            RefreshViews();
            MessageBox.Show("Saved");
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
        }

        private void authorsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (authorsDataGridView.Columns[e.ColumnIndex].Name)
            {
                case "firstNameDataGridViewTextBoxColumn":
                case "lastNameDataGridViewTextBoxColumn":
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

                    break;
            }
        }

        private void authorsDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            authorsDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void booksDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
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
            if (authorsDataGridView.Rows[e.RowIndex].DataBoundItem != null)
            {
                booksDataGridView.AllowUserToAddRows = publishers.Count != 0;
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

        private void publisherBtn_Click(object sender, EventArgs e)
        {
            var publisherForm = new PublisherForm(ref publishersBindingSource);
            publisherForm.ShowDialog();
        }

        private void resetDbBtn_Click(object sender, EventArgs e)
        {
            authorRepository.ResetDb();
            authorRepository.Reset();
            LoadData();
            BindDataSources();
            RefreshViews();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            authorRepository.Reset();
            LoadData();
            BindDataSources();
            RefreshViews();
        }

        private void booksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            booksDataGridView.AllowUserToAddRows = publishers.Count != 0;
        }
    }
}
