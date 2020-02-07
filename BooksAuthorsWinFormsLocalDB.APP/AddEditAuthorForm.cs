using System;
using System.Windows.Forms;
using BooksAuthorsWinFormsLocalDB.DAL;

namespace BooksAuthorsWinFormsLocalDB.APP
{
    public partial class AddEditAuthorForm : Form
    {
        Authors currentAuthor = null;
        public AddEditAuthorForm(Authors author)
        {
            InitializeComponent();
            currentAuthor = author;
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            AcceptButton = submitAuthorChangesBtn;
            AcceptButton.DialogResult = DialogResult.OK;
            authorFirstNameTextBox.Text = currentAuthor.FirstName;
            authorLastNameTextBox.Text = currentAuthor.LastName;
            submitAuthorChangesBtn.Enabled = authorFirstNameTextBox.TextLength >= 2 && authorFirstNameTextBox.TextLength <= 30 && authorLastNameTextBox.TextLength >= 2 && authorLastNameTextBox.TextLength <= 30;

            if (authorFirstNameTextBox.TextLength == 0 && authorLastNameTextBox.TextLength == 0)
            {
                this.Text = "Add New Author";
            }

            else
            {
                this.Text = $"{currentAuthor.FirstName} {currentAuthor.LastName}";
            }

            try
            {
                authorDateOfBirthDateTimePicker.Value = (DateTime)currentAuthor.DateOfBirth;
            }

            catch
            {
                authorDateOfBirthDateTimePicker.Value = authorDateOfBirthDateTimePicker.MinDate;
            }
        }

        private void submitAuthorChangesBtn_Click(object sender, EventArgs e)
        {
            if (currentAuthor != null)
            {
                currentAuthor.FirstName = authorFirstNameTextBox.Text;
                currentAuthor.LastName = authorLastNameTextBox.Text;
                currentAuthor.DateOfBirth = DateTime.Parse(authorDateOfBirthDateTimePicker.Value.ToString());
                DialogResult = DialogResult.OK;
            }
        }

        private void authorFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            submitAuthorChangesBtn.Enabled = authorFirstNameTextBox.TextLength >= 2 && authorFirstNameTextBox.TextLength <= 30 && authorLastNameTextBox.TextLength >= 2 && authorLastNameTextBox.TextLength <= 30;
        }

        private void authorLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            submitAuthorChangesBtn.Enabled = authorFirstNameTextBox.TextLength >= 2 && authorFirstNameTextBox.TextLength <= 30 && authorLastNameTextBox.TextLength >= 2 && authorLastNameTextBox.TextLength <= 30;
        }
    }
}
