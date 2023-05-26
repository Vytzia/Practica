using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Fizzler
{
    public partial class Fizzler : Form
    {
        PaginaLogin pl;
        public static SqlConnection conn;
        string connection_string = "Data Source = RACHELPLYG; Initial Catalog = FIZZLER; Integrated Security=True";
        int n = 0;

        //constructorul clasei
        public Fizzler()
        {
            InitializeComponent();
            
            conn = new SqlConnection(connection_string); //se stabilește de la început conexiunea cu baza de date pentru a fi utilizată ulterior

            pl = new PaginaLogin(this, conn); //se instantiaza o pagina de login si se afiseaza
            this.Controls.Add(pl);
            main_panel.Hide();
            top_panel.Hide();

            CenterUserControl(pl); //se mentine pagina login in centrul ecranului
        }

        //functia ce centreaza un usercontrol
        private void CenterUserControl(UserControl userControl)
        {
            // Calculeaza coordonatele X si Y pentru a centra Usercontrolul
            int newX = (userControl.Parent.Width - userControl.Width) / 2;
            int newY = (userControl.Parent.Height - userControl.Height) / 2;

            // Seteaza locatia usercontrollului
            userControl.Location = new Point(newX, newY);
        }

        private void Fizzler_Load(object sender, EventArgs e)
        {
            //fisierul din care se extrag si se salveaza date despre dimensiunea ferestreid
            string configFilePath = "config.txt";

            //citeste ultima dimensiune al fisierului cand s-a inchis
            if (File.Exists(configFilePath))
            {
                string[] lines = File.ReadAllLines(configFilePath);

                if (lines.Length == 1)
                {
                    string[] parts = lines[0].Split(',');

                    if (parts.Length == 4)
                    {
                        int width, height, x, y;

                        if (int.TryParse(parts[0], out width) && int.TryParse(parts[1], out height) &&
                            int.TryParse(parts[2], out x) && int.TryParse(parts[3], out y))
                        {
                            this.Size = new Size(width, height);
                            this.Location = new Point(x, y);
                        }
                    }
                }
            }
        }

        //bool care se schimba in dependenta daca utilizatorul este admin
        bool isAdmin = false;

        //functie ce este apelata odata ce utilizatorul se logheaza
        //face posibil vederile diferite pentru utilizatori
        public void login(bool admin)
        {
            this.Controls.Remove(pl);
            main_panel.Show();
            top_panel.Show();

            this.isAdmin = admin;

            if (admin)
            {
                button_cos.Hide();
            }
            else
            {
                button_sucuri.Hide();
                button_rapoarte.Hide();
                button_adauga_suc.Hide();
                button_sterge_suc.Hide();
            }

            useDatabase("");

        }
        
        //functie ce adauga o inregistrare din baza de date in panou cu butonul de cumparare (pentru cumparatori)
        void adauga_suc(string id, string nume, float pret, float volum, float procentaj_zahar, string fructe, string categorie, string img)
        {
            Pagina_suc suc = new Pagina_suc(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
            suc.Dock = DockStyle.Top;
            content_panel.Controls.Add(suc);
        }

        //asemanatoare cu cea precedenta, doar ca e farar buton(pentru admin)
        void adauga_suc_fara_buton(string id, string nume, float pret, float volum, float procentaj_zahar, string fructe, string categorie, string img)
        {
            Pagina_suc_delete suc = new Pagina_suc_delete(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
            suc.Dock = DockStyle.Top;
            content_panel.Controls.Add(suc);
        }

        //functie ce citeste si afiseaza datele din baza de date in panou bazat pe un anumit criteriu
        void useDatabase(string selectCriteria)
        {
            content_panel.Controls.Clear();
            conn.Open();
            string query = "SELECT * FROM NiceBauturiView2 " + selectCriteria;
            SqlCommand command = new SqlCommand(query, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
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

                    if (isAdmin)
                    {
                        adauga_suc_fara_buton(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
                    }
                    else
                    {
                        adauga_suc(id, nume, pret, volum, procentaj_zahar, fructe, categorie, img);
                    }
                }
            }
            conn.Close();
        }

        //butonul care confirma modul de sortare
        private void butt_go_Click(object sender, EventArgs e)
        {
            go();
        }

        //functie ce alcatuieste un criteriu de sortare si selectie bazat pe datele care au fost introduse de utilzator in panoul de sortare/filtrare
        public void go()
        {
            string queryString;

            string ye = " ";
            int selectedIndex = comboBox_sortare.SelectedIndex;
            if (selectedIndex != -1)
            {
                ye += "ORDER BY ";
                switch (selectedIndex)
                {
                    case 0:
                        ye = "";
                        break;
                    case 1:
                        ye += "Pret DESC ";
                        break;
                    case 2:
                        ye += "Pret ASC ";
                        break;
                    case 3:
                        ye += "Vanzari ASC";
                        break;
                }
            }

            bool useAnd = false;
            string zahar = "";
            int selectedIndex_zahar = comboBox_zahar.SelectedIndex;
            if (selectedIndex_zahar != -1)
            {
                zahar = " WHERE Procentaj_zahar";
                switch (selectedIndex_zahar)
                {
                    case 0:
                        zahar = "";
                        break;
                    case 1:
                        zahar += "<=10 ";
                        break;
                    case 2:
                        zahar += "<=15 ";
                        break;
                    case 3:
                        zahar += ">15 ";
                        break;
                }
                if (selectedIndex_zahar != 0)
                    useAnd = true;
            }

            string categorie = "";
            foreach (Control control in groupBox_categorii.Controls)
            {
                // Check if the control is a radio button and is checked
                if (control is System.Windows.Forms.RadioButton && ((System.Windows.Forms.RadioButton)control).Checked)
                {
                    if (useAnd)
                    {
                        categorie = " AND ";
                    }
                    else
                    {
                        categorie = " WHERE ";
                        useAnd = true;
                    }
                    // Get the value of the selected radio button
                    string selectedValue = ((System.Windows.Forms.RadioButton)control).Text; // or radioButton.Tag.ToString();

                    // Do something with the selected value
                    Console.WriteLine(selectedValue);
                    categorie += " Categorie = \'" + selectedValue + "\'";

                    break; // exit the loop
                }
            }

            string fruct = "";
            foreach (Control control in groupBox_fructe.Controls)
            {
                // Check if the control is a radio button and is checked
                if (control is System.Windows.Forms.RadioButton && ((System.Windows.Forms.RadioButton)control).Checked)
                {
                    if (useAnd)
                    {
                        fruct = " AND ";
                    }
                    else
                    {
                        fruct = " WHERE ";
                        useAnd = true;
                    }
                    // Get the value of the selected radio button
                    string selectedValue = ((System.Windows.Forms.RadioButton)control).Text; // or radioButton.Tag.ToString();

                    // Do something with the selected value
                    Console.WriteLine(selectedValue);
                    if (selectedValue == "Măr")
                        selectedValue = "M_r";
                    if (selectedValue == "Căpșune")
                        selectedValue = "C_p_une";
                    fruct += " Fructe LIKE \'%" + selectedValue + "%\'";

                    break; // exit the loop
                }
            }

            queryString = zahar + categorie + fruct + ye;

            Console.WriteLine(queryString);
            useDatabase(queryString);
        }

        //functie ce reseteaza criteriile de selectie

        private void clear_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox_categorii.Controls)
            {
                // Check if the control is a radio button and is checked
                if (control is System.Windows.Forms.RadioButton && ((System.Windows.Forms.RadioButton)control).Checked)
                {
                    ((System.Windows.Forms.RadioButton)control).Checked = false;
                }
            }

        }

        //functie ce reseteaza criteriile de selectie
        private void clear_button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox_fructe.Controls)
            {
                // Check if the control is a radio button and is checked
                if (control is System.Windows.Forms.RadioButton && ((System.Windows.Forms.RadioButton)control).Checked)
                {
                    ((System.Windows.Forms.RadioButton)control).Checked = false;
                }
            }
        }

        //butonul ce afiseaza formul de adaugare unui suc nou in baza de date
        private void button_adauga_suc_Click(object sender, EventArgs e)
        {
            Form_Adaugare_Suc newSuc = new Form_Adaugare_Suc(conn, this);
            newSuc.ShowDialog();
        }

        //butonul ce afiseaza formul de stergere unui suc nou in baza de date
        private void button_sterge_suc_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm(conn, this);
            df.ShowDialog();
        }

        //butonul ce afiseaza cosul de cumparaturi cumparatorului
        private void button_cos_Click(object sender, EventArgs e)
        {
            Cos cos = new Cos(conn);
            cos.ShowDialog();
        }

        //butonul ce afiseaza pagina de rapoarte
        private void button_rapoarte_Click(object sender, EventArgs e)
        {
            if (pr != null) main_panel.Controls.Remove(pr);

            pr = new PaginaReport(conn);
            main_panel.Controls.Add(pr);
            side_panel.Hide();
            pr.Dock = DockStyle.Fill;
            pr.BringToFront();
        }
        PaginaReport pr;
        //butonul ce afiseaza pagina de sucuri
        private void button_sucuri_Click(object sender, EventArgs e)
        {
            if (pr == null) return;

            main_panel.Controls.Remove(pr);
            side_panel.Show();
        }
        //butonul ce trece inapoi la pagina de logare
        private void button_login_Click(object sender, EventArgs e)
        {
            RestartApplication();
        }
        //restarteaza aplicatia salvand datele despre dimensiunile programului
        private void RestartApplication()
        {
            // Save the current form size and position to a separate file
            string configFilePath = "config.txt";
            string formSizeString = $"{this.Size.Width},{this.Size.Height}";
            string formLocationString = $"{this.Location.X},{this.Location.Y}";

            File.WriteAllText(configFilePath, $"{formSizeString},{formLocationString}");

            Application.Restart();
        }

        //centreaza pagina de logare
        private void Fizzler_SizeChanged(object sender, EventArgs e)
        {
            if (this.Controls.Contains(pl))
                CenterUserControl(pl);
        }

        //salveaza dimensiunile programului inainte sa se inchida
        private void Fizzler_FormClosing(object sender, FormClosingEventArgs e)
        {
            string configFilePath = "config.txt";
            string formSizeString = $"{this.Size.Width},{this.Size.Height}";
            string formLocationString = $"{this.Location.X},{this.Location.Y}";

            File.WriteAllText(configFilePath, $"{formSizeString},{formLocationString}");
        }
    }
}
