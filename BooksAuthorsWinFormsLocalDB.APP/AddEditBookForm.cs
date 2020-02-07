using BooksAuthorsWinFormsLocalDB.DAL;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BooksAuthorsWinFormsLocalDB.APP
{
    public partial class AddEditBookForm : Form
    {
        Books currentBook = null;

        public AddEditBookForm(Books book, BindingList<PublishingHouses> publishers)
        {
            InitializeComponent();
            currentBook = book;
            publishersComboBox.DataSource = publishers;
            publishersComboBox.ValueMember = "Id";
            publishersComboBox.DisplayMember = "Name";

            if (currentBook.PublishingHouses == null)
            {
                currentBook.PublishingHouses = publishers.FirstOrDefault();
                currentBook.PublisherId = currentBook.PublishingHouses.Id;
            }

            publishersComboBox.SelectedItem = book.PublishingHouses;
        }

        private void bookTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (bookTitleTextBox.TextLength == 0)
            {
                saveBookButton.Enabled = false;
            }

            else
            {
                saveBookButton.Enabled = true;
            }
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            currentBook.Title = bookTitleTextBox.Text;
            currentBook.Year = Convert.ToInt32(publishingYearDateTimePicker.Value.Year.ToString());
            Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            AcceptButton = saveBookButton;
            AcceptButton.DialogResult = DialogResult.OK;
            
            DateTime aux;

            if (currentBook.Year > 1000)
            {
                aux = new DateTime(currentBook.Year, 1, 1);
            }

            else
            {
                aux = publishingYearDateTimePicker.MinDate;
            }

            bookTitleTextBox.Text = currentBook.Title;
            publishingYearDateTimePicker.Value = aux;
        }

        private void publishersComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentBook.PublishingHouses = (publishersComboBox.SelectedItem as PublishingHouses);
            currentBook.PublisherId = (publishersComboBox.SelectedItem as PublishingHouses).Id;
        }
    }
}
