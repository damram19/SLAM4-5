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
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;
        public FFille(FMere maMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            bt_MaMère.Click += new EventHandler(Bt_MaMère_Click);
            this.Load += new EventHandler(FFille_Load);
        }

        private void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur " + this.monNom);
        }

        private void Bt_MaMère_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.maMere.NomMère);
        }

        public string Nom 
        {
            set
            {
                this.monNom = value;
            }
        }
    }
}
