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
    public partial class Cantitate_suc : Form
    {
        string id;
        static SqlConnection conn;
        public Cantitate_suc(string id)
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.id = id;


            string connection_string = "Data Source = RACHELPLYG; Initial Catalog = FIZZLER; Integrated Security=True";
            conn = new SqlConnection(connection_string);
        }

        void go()
        {
            int quantity;
            if (int.TryParse(textBox1.Text, out quantity) && quantity >= 100 && quantity <= 10000)
            {
                Console.WriteLine("Quantity: " + quantity);

                //verifica daca deja se cumpara asa produs
                bool entryExists;

                using (conn)
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Vanzari WHERE ID_bautura = @ID_bautura AND Vandut=0";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ID_bautura", id);

                        int rowCount = (int)command.ExecuteScalar();
                        entryExists = rowCount > 0;
                    }
                    conn.Close();
                }

                string connection_string = "Data Source = RACHELPLYG; Initial Catalog = FIZZLER; User ID = fizz_admin; Password = 123; MultipleActiveResultSets=true";
                SqlConnection connection = new SqlConnection(connection_string);

                using (connection)
                {
                    connection.Open();
                    if (entryExists)
                    {
                        string updateQuery = $"UPDATE Vanzari SET Nr_vanzari = Nr_vanzari + {quantity} WHERE ID_bautura = '{id}'";
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        int rowsAffected1 = command.ExecuteNonQuery();
                    }
                    else
                    {
                        adauga_cumparatura_in_cos(quantity, connection);
                    }
                    connection.Close();
                }

                MessageBox.Show($"S-au adăugat cu succes {quantity} produse în coș!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid natural number.", "Error");
            }
        }

        private void button_cumpara_Click(object sender, EventArgs e)
        {
            go();
        }

        void adauga_cumparatura_in_cos(int quantity, SqlConnection connection)
        {
            string query = $"INSERT INTO Vanzari(ID_bautura, Nr_vanzari, Vandut) VALUES('{id}', {quantity}, 0)";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected1 = command.ExecuteNonQuery();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_cumpara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                go();
            }
        }

    }
}
