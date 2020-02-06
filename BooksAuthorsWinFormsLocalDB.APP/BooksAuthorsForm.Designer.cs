namespace BooksAuthorsWinFormsLocalDB.APP
{
    partial class BooksAuthorsForm
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
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDropdownColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.publisherBtn = new System.Windows.Forms.Button();
            this.resetDbBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.AutoGenerateColumns = false;
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.booksDataGridViewTextBoxColumn});
            this.authorsDataGridView.DataSource = this.authorsBindingSource;
            this.authorsDataGridView.Location = new System.Drawing.Point(33, 29);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.Size = new System.Drawing.Size(544, 453);
            this.authorsDataGridView.TabIndex = 0;
            this.authorsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellEndEdit);
            this.authorsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellEnter);
            this.authorsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellValidated);
            this.authorsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.authorsDataGridView_CellValidating);
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.Authors);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.publisherIdDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.authorsDataGridViewTextBoxColumn,
            this.publishingHousesDataGridViewTextBoxColumn,
            this.publisherDropdownColumn});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(620, 29);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(444, 453);
            this.booksDataGridView.TabIndex = 1;
            this.booksDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellEndEdit);
            this.booksDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellValidated);
            this.booksDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.booksDataGridView_CellValidating);
            this.booksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.booksDataGridView_DataError);
            this.booksDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.booksDataGridView_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ToolTipText = "yyyy";
            // 
            // publisherIdDataGridViewTextBoxColumn
            // 
            this.publisherIdDataGridViewTextBoxColumn.DataPropertyName = "PublisherId";
            this.publisherIdDataGridViewTextBoxColumn.HeaderText = "PublisherId";
            this.publisherIdDataGridViewTextBoxColumn.Name = "publisherIdDataGridViewTextBoxColumn";
            this.publisherIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            this.authorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorsDataGridViewTextBoxColumn
            // 
            this.authorsDataGridViewTextBoxColumn.DataPropertyName = "Authors";
            this.authorsDataGridViewTextBoxColumn.HeaderText = "Authors";
            this.authorsDataGridViewTextBoxColumn.Name = "authorsDataGridViewTextBoxColumn";
            this.authorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // publishingHousesDataGridViewTextBoxColumn
            // 
            this.publishingHousesDataGridViewTextBoxColumn.DataPropertyName = "PublishingHouses";
            this.publishingHousesDataGridViewTextBoxColumn.HeaderText = "PublishingHouses";
            this.publishingHousesDataGridViewTextBoxColumn.Name = "publishingHousesDataGridViewTextBoxColumn";
            this.publishingHousesDataGridViewTextBoxColumn.Visible = false;
            // 
            // publisherDropdownColumn
            // 
            this.publisherDropdownColumn.DataPropertyName = "PublisherId";
            this.publisherDropdownColumn.DataSource = this.publishersBindingSource;
            this.publisherDropdownColumn.DisplayMember = "Name";
            this.publisherDropdownColumn.HeaderText = "Publisher";
            this.publisherDropdownColumn.Name = "publisherDropdownColumn";
            this.publisherDropdownColumn.ValueMember = "Id";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.PublishingHouses);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.Books);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(1145, 101);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(75, 23);
            this.saveChangesBtn.TabIndex = 2;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // publisherBtn
            // 
            this.publisherBtn.Location = new System.Drawing.Point(1145, 142);
            this.publisherBtn.Name = "publisherBtn";
            this.publisherBtn.Size = new System.Drawing.Size(75, 23);
            this.publisherBtn.TabIndex = 3;
            this.publisherBtn.Text = "Publishers";
            this.publisherBtn.UseVisualStyleBackColor = true;
            this.publisherBtn.Click += new System.EventHandler(this.publisherBtn_Click);
            // 
            // resetDbBtn
            // 
            this.resetDbBtn.Location = new System.Drawing.Point(1145, 186);
            this.resetDbBtn.Name = "resetDbBtn";
            this.resetDbBtn.Size = new System.Drawing.Size(75, 23);
            this.resetDbBtn.TabIndex = 4;
            this.resetDbBtn.Text = "Reset DB";
            this.resetDbBtn.UseVisualStyleBackColor = true;
            this.resetDbBtn.Click += new System.EventHandler(this.resetDbBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1145, 230);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // booksDataGridViewTextBoxColumn
            // 
            this.booksDataGridViewTextBoxColumn.DataPropertyName = "Books";
            this.booksDataGridViewTextBoxColumn.HeaderText = "Books";
            this.booksDataGridViewTextBoxColumn.Name = "booksDataGridViewTextBoxColumn";
            this.booksDataGridViewTextBoxColumn.Visible = false;
            // 
            // BooksAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 523);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.resetDbBtn);
            this.Controls.Add(this.publisherBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.authorsDataGridView);
            this.Name = "BooksAuthorsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingHousesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisherDropdownColumn;
        private System.Windows.Forms.Button publisherBtn;
        private System.Windows.Forms.Button resetDbBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksDataGridViewTextBoxColumn;
    }
}

