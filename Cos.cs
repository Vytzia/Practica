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
    public partial class Cos : Form
    {
        SqlConnection conn;
        public Cos(SqlConnection conn)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.conn = conn;
            refresh();
        }

        public void refresh()
        {
            panel.Controls.Clear();
            arataChestiileDinCos();
            afiseazaSuma();
        }

        void afiseazaSuma()
        {
            int nr_vanzari = 0;
            double sum = 0;
            conn.Open();
            string query = "SELECT SUM(Nr_vanzari) FROM NiceBauturiVanzariView WHERE Vandut=0";
            SqlCommand command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        nr_vanzari = reader.GetInt32(0);
                    }
                }
            }

            string query2 = "SELECT cast(Sum(Nr_vanzari*cast(Pret as float)) as float) FROM NiceBauturiVanzariView WHERE Vandut = 0";
            SqlCommand command2 = new SqlCommand(query2, conn);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        sum = reader.GetDouble(0);
                    }
                }
            }

            conn.Close();

            textBox_cantitate_totala.Text = "Cantitate produse: " + nr_vanzari;
            textBox_pret_total.Text = "Cost total: " + sum;
        }

        void arataChestiileDinCos()
        {
            conn.Open();
            string query = "SELECT ID, Bautura, Pret, Volum, Procentaj_zahar, Fructe, Categorie, Img, Nr_vanzari, Vandut FROM NiceBauturiVanzariView";
            SqlCommand command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(9)) continue;

                    string id = reader.GetString(0);

                    string nume = "";
                    if (!reader.IsDBNull(1))
                        nume = reader.GetString(1);

                    float pret = (float)reader.GetDecimal(2);

                    float volum = (float)reader.GetDecimal(3);

                    float procentaj_zahar = (float)reader.GetDecimal(4);

                    string fructe = "";
                    if (!reader.IsDBNull(5))
                        fructe = reader.GetString(5);

                    string categorie = reader.GetString(6);
                    string img = reader.GetString(7);

                    int nrVanzari = reader.GetInt32(8);

                    adauga_suc(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img, nrVanzari);
                }
            }
            conn.Close();
        }

        void adauga_suc(string id, string nume, float pret, float volum, float procentaj_zahar, string fructe, string categorie, string img, int nrVanzari)
        {
            Pagina_suc_cos suc = new Pagina_suc_cos(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img, nrVanzari);
            suc.Dock = DockStyle.Top;
            panel.Controls.Add(suc);
        }

        private void button_cumpara_Click(object sender, EventArgs e)
        {
            int rowsAffected = 0;
            conn.Open();

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string query = $"UPDATE Vanzari SET Vandut = 1, Data = '{currentDate}' WHERE Vandut = 0";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                rowsAffected = command.ExecuteNonQuery();
            }

            conn.Close();

            refresh();

            if (rowsAffected != 0)
            {
                MessageBox.Show("Ati achitat cu succes!!");
                this.Close();
            }
        }
    }
}
