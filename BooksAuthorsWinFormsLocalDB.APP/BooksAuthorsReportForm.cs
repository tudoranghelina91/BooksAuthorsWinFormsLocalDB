using BooksAuthorsWinFormsLocalDB.DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace BooksAuthorsWinFormsLocalDB.APP
{
    public partial class BooksAuthorsReportForm : Form
    {
        Authors author = null;
        PublishingHouses publishingHouses = null;

        public BooksAuthorsReportForm(Authors author)
        {
            InitializeComponent();
            this.author = author;
        }

        public BooksAuthorsReportForm(PublishingHouses publishingHouses)
        {
            InitializeComponent();
            this.publishingHouses = publishingHouses;
        }

        private void BooksAuthorsReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (author != null)
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter("AuthorName", $"{author.FirstName} {author.LastName}"));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BooksForAuthor", author.Books));
            }

            else if (publishingHouses != null)
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter("AuthorName", $"{publishingHouses.Name}"));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BooksForAuthor", publishingHouses.Books));
            }

            if(reportViewer1.PrinterSettings.CanDuplex)
            {
                reportViewer1.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Vertical;
            }

            else
            {
                reportViewer1.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Default;
            }
        }
    }
}
