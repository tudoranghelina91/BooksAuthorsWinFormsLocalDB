using BooksAuthorsWinFormsLocalDB.DAL;
using BooksAuthorsWinFormsLocalDB.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksAuthorsWinFormsLocalDB.APP
{
    public partial class PublisherForm : Form
    {
        BindingSource bindingSource;
        public PublisherForm(ref BindingSource bindingSource)
        {
            this.bindingSource = bindingSource;
            InitializeComponent();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            publishersDataGridView.DataSource = bindingSource;
            //if (publishersDataGridView.IsCurrentCellInEditMode)
            //{
            //    publishersDataGridView.CancelEdit();
            //}
        }

        private void publishersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (publishersDataGridView.IsCurrentCellDirty && publishersDataGridView.Columns[e.ColumnIndex].Name == "nameDataGridViewTextBoxColumn")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    publishersDataGridView.Rows[e.RowIndex].ErrorText = $"{publishersDataGridView.Columns[e.ColumnIndex].HeaderText} Cannot be empty";
                }

                else if (e.FormattedValue.ToString().Length < 2)
                {
                    e.Cancel = true;
                    publishersDataGridView.Rows[e.RowIndex].ErrorText = $"{publishersDataGridView.Columns[e.ColumnIndex].HeaderText} is too short";
                }

                else if (e.FormattedValue.ToString().Length > 50)
                {
                    e.Cancel = true;
                    publishersDataGridView.Rows[e.RowIndex].ErrorText = $"{publishersDataGridView.Columns[e.ColumnIndex].HeaderText} is too long";
                }

                else
                {
                    publishersDataGridView.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void publishersDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(publishersDataGridView.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value) == 0)
            {
                new PublisherRepository().SetLocalId(publishersDataGridView.Rows[e.RowIndex].DataBoundItem as PublishingHouses);
            }

            publishersDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void PublisherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (publishersDataGridView.IsCurrentCellInEditMode)
            {
                e.Cancel = true;
                publishersDataGridView.EndEdit();
            }

            else
            {
                publishersDataGridView.DataSource = null;
            }
        }

        private void showBooksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booksAuthorsReportForm = new BooksAuthorsReportForm(publishersDataGridView.CurrentCell.OwningRow.DataBoundItem as PublishingHouses);
            booksAuthorsReportForm.ShowDialog();
        }

        private void publishersDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (publishersDataGridView.CurrentCell != null && e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                if (publishersDataGridView.CurrentCell.OwningRow.DataBoundItem as PublishingHouses != null)
                {
                    publishersDataGridView.ClearSelection();
                    publishersDataGridView.Rows[e.RowIndex].Selected = true;
                    publishersDataGridView.CurrentCell = publishersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }

        private void publishersContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (publishersDataGridView.CurrentCell.OwningRow.DataBoundItem as PublishingHouses == null)
            {
                showBooksReportToolStripMenuItem.Enabled = false;
            }

            else
            {
                showBooksReportToolStripMenuItem.Enabled = true;
            }
        }
    }
}
