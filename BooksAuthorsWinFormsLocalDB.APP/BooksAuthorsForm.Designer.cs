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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBooksReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingHousesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDropdownColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            this.authorsMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            this.booksMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.mainMenu.SuspendLayout();
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
            this.authorsDataGridView.ContextMenuStrip = this.authorsMenuStrip;
            this.authorsDataGridView.DataSource = this.authorsBindingSource;
            this.authorsDataGridView.Location = new System.Drawing.Point(12, 29);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.authorsDataGridView.Size = new System.Drawing.Size(494, 453);
            this.authorsDataGridView.TabIndex = 0;
            this.authorsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.authorsDataGridView_CellBeginEdit);
            this.authorsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellEndEdit);
            this.authorsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellEnter);
            this.authorsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.authorsDataGridView_CellMouseDown);
            this.authorsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_CellValidated);
            this.authorsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.authorsDataGridView_CellValidating);
            this.authorsDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorsDataGridView_RowValidated);
            this.authorsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.authorsDataGridView_RowValidating);
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
            // authorsMenuStrip
            // 
            this.authorsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.editAuthorToolStripMenuItem,
            this.showBooksReportToolStripMenuItem});
            this.authorsMenuStrip.Name = "authorsMenuStrip";
            this.authorsMenuStrip.Size = new System.Drawing.Size(177, 70);
            this.authorsMenuStrip.Text = "Edit Author";
            this.authorsMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.authorsMenuStrip_Opening);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // editAuthorToolStripMenuItem
            // 
            this.editAuthorToolStripMenuItem.Name = "editAuthorToolStripMenuItem";
            this.editAuthorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.editAuthorToolStripMenuItem.Text = "Edit";
            this.editAuthorToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // showBooksReportToolStripMenuItem
            // 
            this.showBooksReportToolStripMenuItem.Name = "showBooksReportToolStripMenuItem";
            this.showBooksReportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showBooksReportToolStripMenuItem.Text = "Show Books Report";
            this.showBooksReportToolStripMenuItem.Click += new System.EventHandler(this.showBooksReportToolStripMenuItem_Click);
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
            this.booksDataGridView.ContextMenuStrip = this.booksMenuStrip;
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(524, 29);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(497, 453);
            this.booksDataGridView.TabIndex = 1;
            this.booksDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.booksDataGridView_CellBeginEdit);
            this.booksDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellEndEdit);
            this.booksDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.booksDataGridView_CellMouseDown);
            this.booksDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellValidated);
            this.booksDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.booksDataGridView_CellValidating);
            this.booksDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.booksDataGridView_CurrentCellDirtyStateChanged);
            this.booksDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.booksDataGridView_DataError);
            this.booksDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.booksDataGridView_DefaultValuesNeeded);
            this.booksDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_RowValidated);
            this.booksDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.booksDataGridView_UserDeletingRow);
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.PublishingHouses);
            // 
            // booksMenuStrip
            // 
            this.booksMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookToolStripMenuItem});
            this.booksMenuStrip.Name = "booksMenuStrip";
            this.booksMenuStrip.Size = new System.Drawing.Size(125, 26);
            this.booksMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.booksMenuStrip_Opening);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.Books);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addNewAuthorToolStripMenuItem,
            this.publishersToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1030, 24);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addNewAuthorToolStripMenuItem
            // 
            this.addNewAuthorToolStripMenuItem.Name = "addNewAuthorToolStripMenuItem";
            this.addNewAuthorToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.addNewAuthorToolStripMenuItem.Text = "Add New Author";
            this.addNewAuthorToolStripMenuItem.Click += new System.EventHandler(this.addNewAuthorToolStripMenuItem_Click);
            // 
            // publishersToolStripMenuItem
            // 
            this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            this.publishersToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.publishersToolStripMenuItem.Text = "Publishers";
            this.publishersToolStripMenuItem.Click += new System.EventHandler(this.publishersToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
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
            this.publisherIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.authorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // publishingHousesDataGridViewTextBoxColumn
            // 
            this.publishingHousesDataGridViewTextBoxColumn.DataPropertyName = "PublishingHouses";
            this.publishingHousesDataGridViewTextBoxColumn.HeaderText = "PublishingHouses";
            this.publishingHousesDataGridViewTextBoxColumn.Name = "publishingHousesDataGridViewTextBoxColumn";
            this.publishingHousesDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BooksAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 501);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.authorsDataGridView);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "BooksAuthorsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            this.authorsMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            this.booksMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip authorsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip booksMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBooksReportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingHousesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn publisherDropdownColumn;
    }
}

