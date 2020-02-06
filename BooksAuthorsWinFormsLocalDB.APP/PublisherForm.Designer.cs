namespace BooksAuthorsWinFormsLocalDB.APP
{
    partial class PublisherForm
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
            this.publishersDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publishersDataGridView
            // 
            this.publishersDataGridView.AutoGenerateColumns = false;
            this.publishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.booksDataGridViewTextBoxColumn});
            this.publishersDataGridView.DataSource = this.publishingHousesBindingSource;
            this.publishersDataGridView.Location = new System.Drawing.Point(23, 13);
            this.publishersDataGridView.Name = "publishersDataGridView";
            this.publishersDataGridView.Size = new System.Drawing.Size(465, 413);
            this.publishersDataGridView.TabIndex = 0;
            this.publishersDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.publishersDataGridView_CellValidated);
            this.publishersDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.publishersDataGridView_CellValidating);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // booksDataGridViewTextBoxColumn
            // 
            this.booksDataGridViewTextBoxColumn.DataPropertyName = "Books";
            this.booksDataGridViewTextBoxColumn.HeaderText = "Books";
            this.booksDataGridViewTextBoxColumn.Name = "booksDataGridViewTextBoxColumn";
            this.booksDataGridViewTextBoxColumn.Visible = false;
            // 
            // publishingHousesBindingSource
            // 
            this.publishingHousesBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.PublishingHouses);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(BooksAuthorsWinFormsLocalDB.DAL.Books);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 486);
            this.Controls.Add(this.publishersDataGridView);
            this.Name = "PublisherForm";
            this.Text = "PublisherForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PublisherForm_FormClosing);
            this.Load += new System.EventHandler(this.PublisherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView publishersDataGridView;
        private System.Windows.Forms.BindingSource publishingHousesBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksDataGridViewTextBoxColumn;
    }
}