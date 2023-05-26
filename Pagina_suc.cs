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
    public partial class Pagina_suc : UserControl
    {
        string cod_produs;
        //constructorul paginii de suc
        public Pagina_suc(string cod_produs, string nume, float pret, float cantitate,float procentaj_zahar, string fructe, string categorie, string imagine_sursa)
        {
            InitializeComponent();

            this.cod_produs = cod_produs;
            textBox_nume.Text = nume;
            textBox_pret.Text = pret.ToString() + " lei";
            textBox_volum.Text = cantitate.ToString()+" l";
            textBox_fructe.Text = "Fructe: "+fructe;
            textBox_proc_zahar.Text = "Procentaj zahăr: "+procentaj_zahar.ToString()+"%";
            textBox_categorii.Text = "Categorie: " + categorie;

            if (!String.IsNullOrEmpty(imagine_sursa))
                picture.BackgroundImage = Image.FromFile(imagine_sursa);

        }
        //butonul care permite cumpararea produselor
        private void button_cumpara_Click(object sender, EventArgs e)
        {
            Cantitate_suc cs = new Cantitate_suc(cod_produs);
            cs.ShowDialog();
        }
    }
}
