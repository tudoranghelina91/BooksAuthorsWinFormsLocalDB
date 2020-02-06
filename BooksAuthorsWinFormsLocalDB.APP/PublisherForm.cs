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
                publishersDataGridView.EndEdit();
                e.Cancel = true;
            }

            else
            {
                publishersDataGridView.DataSource = null;
            }
        }
    }
}
