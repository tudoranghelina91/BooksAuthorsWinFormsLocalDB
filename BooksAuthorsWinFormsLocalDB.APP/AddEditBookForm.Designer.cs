namespace BooksAuthorsWinFormsLocalDB.APP
{
    partial class AddEditBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.publishingYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.publishingYearLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.publishersComboBox = new System.Windows.Forms.ComboBox();
            this.booksAuthorsReportFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthorsReportFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBookButton
            // 
            this.saveBookButton.Location = new System.Drawing.Point(99, 152);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(121, 23);
            this.saveBookButton.TabIndex = 12;
            this.saveBookButton.Text = "Save changes";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // publishingYearDateTimePicker
            // 
            this.publishingYearDateTimePicker.CustomFormat = "yyyy";
            this.publishingYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.publishingYearDateTimePicker.Location = new System.Drawing.Point(15, 76);
            this.publishingYearDateTimePicker.Name = "publishingYearDateTimePicker";
            this.publishingYearDateTimePicker.ShowUpDown = true;
            this.publishingYearDateTimePicker.Size = new System.Drawing.Size(94, 20);
            this.publishingYearDateTimePicker.TabIndex = 11;
            // 
            // publishingYearLabel
            // 
            this.publishingYearLabel.AutoSize = true;
            this.publishingYearLabel.Location = new System.Drawing.Point(12, 59);
            this.publishingYearLabel.Name = "publishingYearLabel";
            this.publishingYearLabel.Size = new System.Drawing.Size(80, 13);
            this.publishingYearLabel.TabIndex = 10;
            this.publishingYearLabel.Text = "Publishing Year";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.bookTitleLabel.TabIndex = 9;
            this.bookTitleLabel.Text = "Title";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(12, 25);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(287, 20);
            this.bookTitleTextBox.TabIndex = 8;
            this.bookTitleTextBox.TextChanged += new System.EventHandler(this.bookTitleTextBox_TextChanged);
            // 
            // publishersComboBox
            // 
            this.publishersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publishersComboBox.FormattingEnabled = true;
            this.publishersComboBox.Location = new System.Drawing.Point(152, 76);
            this.publishersComboBox.Name = "publishersComboBox";
            this.publishersComboBox.Size = new System.Drawing.Size(121, 21);
            this.publishersComboBox.TabIndex = 13;
            this.publishersComboBox.SelectionChangeCommitted += new System.EventHandler(this.publishersComboBox_SelectionChangeCommitted);
            // 
            // booksAuthorsReportFormBindingSource
            // 
            this.booksAuthorsReportFormBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.APP.BooksAuthorsReportForm);
            // 
            // AddEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 203);
            this.Controls.Add(this.publishersComboBox);
            this.Controls.Add(this.saveBookButton);
            this.Controls.Add(this.publishingYearDateTimePicker);
            this.Controls.Add(this.publishingYearLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Name = "AddEditBookForm";
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthorsReportFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.DateTimePicker publishingYearDateTimePicker;
        private System.Windows.Forms.Label publishingYearLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.ComboBox publishersComboBox;
        private System.Windows.Forms.BindingSource booksAuthorsReportFormBindingSource;
    }
}