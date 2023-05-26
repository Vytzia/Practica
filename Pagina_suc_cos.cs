using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizzler
{
    public partial class Pagina_suc_cos : UserControl
    {
        string id;
        public Pagina_suc_cos(string id, string nume, float pret, float cantitate, float procentaj_zahar, string fructe, string categorie, string imagine_sursa, int nrVanzari)
        {
            InitializeComponent();

            this.id = id;
            textBox_nume.Text = nume;
            textBox_pret.Text = pret.ToString() + " lei";
            textBox_volum.Text = cantitate.ToString() + " l";
            textBox_fructe.Text = "Fructe: " + fructe;
            textBox_proc_zahar.Text = "Procentaj zahăr: " + procentaj_zahar.ToString() + "%";
            textBox_categorii.Text = "Categorie: " + categorie;
            textBox_cantitate.Text = "Cantitate: " + nrVanzari;
            textBox_pret_total.Text = ((double)(pret * nrVanzari)).ToString("0.##") + " lei";

            if (!String.IsNullOrEmpty(imagine_sursa))
                picture.BackgroundImage = Image.FromFile(imagine_sursa);

        }



        private void button_sterge_Click(object sender, EventArgs e)
        {

            string connection_string = "Data Source = RACHELPLYG; Initial Catalog = FIZZLER; User ID = fizz_admin; Password = 123; MultipleActiveResultSets=true";
            SqlConnection conn = new SqlConnection(connection_string);

            string query = $"DELETE FROM Vanzari WHERE ID_bautura = '{id}' AND Vandut = 0";

            conn.Open();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }

            Cos cos = (Cos)this.Parent.Parent;

            cos.refresh();
        }
    }
}