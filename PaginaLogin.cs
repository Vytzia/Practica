using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class PaginaLogin : UserControl
    {
        Fizzler fizz;
        SqlConnection conn;
        public PaginaLogin(Fizzler fizz, SqlConnection conn)
        {
            InitializeComponent();
            this.fizz = fizz;
            this.conn = conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nu ați introdus numele utilizatorului!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introduceți parola!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"SELECT Nume, Parola FROM Utilizatori WHERE Nume=@Nume";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Nume", username);

            bool logged = false;
            bool isAdmin = username == "admin";

            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string db_password = reader.GetString(1);

                        logged = db_password == password;
                    }
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu exista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
            }
            conn.Close();

            if(!logged)
            {
                MessageBox.Show("Parola incorecta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isAdmin)
            {
                Console.WriteLine("Accesat ca admin.");
                fizz.login(true);
            }
            else
            {
                Console.WriteLine("Accesat ca utilizator.");
                fizz.login(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
