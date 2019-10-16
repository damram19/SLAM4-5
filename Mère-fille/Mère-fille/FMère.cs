using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mère_fille
{
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;
        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFille>();
            bt_New.Click += new EventHandler(Bt_New_Click);
            bt_New.Click += new EventHandler(Bt_New_Click_Message);
            bt_Show.Click += new EventHandler(Bt_Show_Click);
            bt_Hide.Click += new EventHandler(Bt_Hide_Click);
            bt_ShDial.Click += new EventHandler(Bt_ShDial_Click);
            bt_Close.Click += new EventHandler(Bt_Close_Click);
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {

            this.lesFilles[lbLesFilles.SelectedIndex].Close();
        }

        private void Bt_ShDial_Click(object sender, EventArgs e)
        {
            this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
        }

        private void Bt_Hide_Click(object sender, EventArgs e)
        {
            this.lesFilles[lbLesFilles.SelectedIndex].Hide();
        }

        private void Bt_Show_Click(object sender, EventArgs e)
        {
            if(lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        private void Bt_New_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }

        private void Bt_New_Click(object sender, EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this, nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
        }

        public string NomMère
        {
            get
            {
                return this.nomMere;
            }
        }
        private void FMere_Load(object sender, EventArgs e)
        {

        }

        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            ffille.Nom = nouveauNom;

        }
    }
}
