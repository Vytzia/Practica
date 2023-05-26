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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fizzler
{
    public partial class Form_Adaugare_Suc : Form
    {
        public SqlConnection conn;
        Fizzler fizz;

        //constructorul formului care necesita conexiunea la baza de date care o ia din formul principal, si referinta la instanta formului principal
        public Form_Adaugare_Suc(SqlConnection conn, Fizzler fizz)
        {
            this.fizz= fizz;
            InitializeComponent();
            label_ID.Visible = false;
            this.conn = conn;
            comboBox_ID.SelectedIndex = 0;
            comboBox_categorie.SelectedIndex = 0;
        }

        //urmatoarele doua functii afiseaza un indiciu la modul in care trebuie sa fie formatat ID-ul
        private void textBox_ID_Enter(object sender, EventArgs e)
        {
            label_ID.Visible = true;
        }

        private void textBox_ID_Leave(object sender, EventArgs e)
        {
            label_ID.Visible = false;
        }

        //butonul ce selecteaza imaginea din fisier
        string image_source = "";
        private void button_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file here
                image_source = openFileDialog1.FileName;
                // Do something with the selected file
                button_image.BackgroundImage = Image.FromFile(image_source);

                Console.WriteLine(image_source);

                button_image.Text = "";
            }
        }
        //face astfel ca sa poata fi introduse doar numere
        private void textBox_pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica daca valoarea introdusa e un numar sau punct
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite un singur punct
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        //butonul anuleaza ce inchide form-ul
        private void button_anuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //permite doar numere naturale
        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //functie ce colecteaza toate datele introduse de utilizator
        //verifica daca toate datele corespund criteriilor
        //daca sunt valide, acestea urmeaza a fi introduse in baza de date
        private void button_adauga_Click(object sender, EventArgs e)
        {
            string id = comboBox_ID.Text + textBox_ID.Text;
            string nume_bautura = textBox_nume.Text;
            string pret = textBox_pret.Text;
            string volum = textBox_volum.Text;
            string zahar = textBox_proc_zahar.Text;
            int categorie = comboBox_categorie.SelectedIndex+1;
            string image = image_source;
            List<int> fructe = new List<int>();
            for (int i = 0; i < checkedListBox_fructe.Items.Count; i++)
            {
                if (checkedListBox_fructe.GetItemChecked(i))
                {
                    fructe.Add(i+1);
                }
            }


            bool eroare = false;
            string query = "SELECT COUNT(*) FROM NiceBauturiView WHERE ID=\'" + id + "\'";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int nrOfInstances = reader.GetInt32(0);

                    if (nrOfInstances > 0)
                    {
                        MessageBox.Show("ID-ul este deja utilizat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        eroare = true;
                    }
                }
            }
            conn.Close();
            if (eroare)
            {
                return;
            }

            if (id.Length != 6)
            {
                MessageBox.Show("Lungimea ID-ului nu corespunde standartului.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("ID: "+id);
                return;
            }

            if(String.IsNullOrEmpty(pret) || float.Parse(pret) == 0)
            {
                MessageBox.Show("Prețul nu e inserat sau a fost inserat incorect. (Trebuie sa fie >0 lei)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(volum) || float.Parse(volum) == 0)
            {
                MessageBox.Show("Volumul nu e inserat sau a fost inserat incorect. (Trebuie sa fie >0 l)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(zahar) || float.Parse(zahar) >50)
            {
                MessageBox.Show("Procentajul zaharului nu e inserat sau a fost inserat incorect. (Trebuie sa fie <=50%)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fructe.Count == 0)
            {
                MessageBox.Show("Nu au fost selectate fructe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //$"My name is {name} and I am {age} years old.";
            string bauturi_query = $"INSERT INTO Bauturi VALUES ('{id}', '{nume_bautura}', {pret}, {volum}, {zahar}, '{image}'); \n";
            string categorii_query = $"INSERT INTO Categorii_Bauturi VALUES ('{id}', {categorie}); \n";

            string fructe_query = "INSERT INTO Fructe_Bauturi VALUES ";
            for(int i = 0; i<fructe.Count; i++)
            {
                if (i!=0) fructe_query+= ", ";
                fructe_query+= $"({fructe[i]}, '{id}')";
            }

            query = bauturi_query + categorii_query+ fructe_query;

            Console.WriteLine(query);

            conn.Open();
            SqlCommand command1 = new SqlCommand(query, conn);
            int rowsAffected1 = command1.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sucul a fost adăugat cu succes!");
            this.Close();

        }

        //cand form-ul e inchis, acesta apeleaza la functia go() din form-ul de baza pentru a
        //face un ”refresh” al datelor din pagina pentru a tine cont de sucul nou-introdus
        private void Form_Adaugare_Suc_FormClosing(object sender, FormClosingEventArgs e)
        {
            fizz.go();
        }

        //verifica ca volumul sa poata fi doar numere zecimale pozitive
        private void textBox_volum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        //verifica ca procentajul de zahar sa poata fi doar numere zecimale pozitive
        private void textBox_proc_zahar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


    }
}
