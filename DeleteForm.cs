using System;
using System.Collections;
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
    public partial class DeleteForm : Form
    {
        SqlConnection conn;
        Fizzler fizz;
        string current_id;
        //constructorul formului care necesita conexiunea la baza de date care o ia din formul principal, si referinta la instanta formului principal
        public DeleteForm(SqlConnection conn, Fizzler fizz)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.conn = conn;
            this.fizz = fizz;
        }
        //sterge sucul din panoul pentru previzualizarea sucului ce urmeaza a fi sters
        void clear()
        {
            current_id= null;
            panel_suc.Controls.Clear();
        }
        //buton ce cauta sucul in baza de date dupa ID-ul introdus
        //daca nu exista, va aparea un mesaj informativa
        //daca exista, sucul va aparea in panoul de previzualizare
        private void button_cautare_Click(object sender, EventArgs e)
        {
            string id = textBox_ID.Text;

            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Introduceți ID-ul!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                return;
            }

            conn.Open();
            string query = $"SELECT * FROM NiceBauturiView WHERE ID='{textBox_ID.Text}'";
            SqlCommand command1 = new SqlCommand(query, conn);
            using (SqlDataReader reader = command1.ExecuteReader())
            {

                if (!reader.HasRows)
                {
                    MessageBox.Show("Nu există suc cu asemenea ID în baza de date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    conn.Close();
                    return;
                }

                while (reader.Read())
                {
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

                    adauga_suc(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
                }
                
            }
            conn.Close();
        }

        //se adauga sucul in panoul de previzualizare
        void adauga_suc(string id, string nume, float pret, float volum, float procentaj_zahar, string fructe, string categorie, string img)
        {
            Pagina_suc_delete suc = new Pagina_suc_delete(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
            panel_suc.Controls.Clear();
            panel_suc.Controls.Add(suc);
            current_id = id;
        }
        //confirma stergerea sucului din baza de date
        private void button_confirm_Click(object sender, EventArgs e)
        {
            string id = current_id;
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID-ul nu a fost încă selectat!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
                conn.Close();
                return;
            }
            string query = $"DELETE FROM Categorii_Bauturi WHERE ID_bautura='{id}'";
            string query1 = $" DELETE FROM Fructe_Bauturi WHERE ID_bautura='{id}'";
            string query2 = $"DELETE FROM Bauturi WHERE ID = '{id}'";
            string query3 = $"DELETE FROM Vanzari WHERE ID_bautura = '{id}'";
            
            conn.Open();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand(query1, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand(query3, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand(query2, conn))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
            MessageBox.Show("Sucul a fost șters cu succes!");
            conn.Close();
            fizz.Focus();
            fizz.go();
            this.Close();
        }
        //inchide formul
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
