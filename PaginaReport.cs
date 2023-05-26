using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizzler
{
    public partial class PaginaReport : UserControl
    {
        SqlConnection conn;
        public PaginaReport(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }
        
        //functie ce afiseaza raportul ales dupa butoane
        void initializeazaReportul(string sqlQuery, string reportPath)
        {
            SqlCommand command = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = reportPath;
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
        //butoanele urmatoare afiseaza reporturile corespunzatoare in reportviewer
        private void button_vanzari_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string query = $"SELECT * FROM NiceBauturiVanzariView WHERE Data = '{currentDate}'";
            string reportPath = "Report2.rdlc";
            initializeazaReportul(query, reportPath);
        }

        private void button_fructe_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM FructeUtilizate";
            string reportPath = "Report1.rdlc";
            initializeazaReportul(query, reportPath);
        }

        private void button_media_preturilor_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PretMediuCategorie";
            string reportPath = "Report3.rdlc";
            initializeazaReportul(query, reportPath);
        }

    }
}
