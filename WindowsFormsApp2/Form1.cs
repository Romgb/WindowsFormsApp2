using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlabel1_Click(object sender, EventArgs e)
        {

        }

        private void ZoneTexte_TextChanged(object sender, EventArgs e)
        {
            if (ZoneTexte.Text == string.Empty)
            {
                boxChoix.Enabled = false;
            }

            else
            {
                boxChoix.Enabled = true;
            }

            zoneTexteCible.Text = ZoneTexte.Text;
        }

        #region Groupe Choix

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                gBoxFond.Enabled = true;
            }
            else
            {
                gBoxFond.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                gBoxCara.Enabled = true;
            }
            else
            {
                gBoxCara.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                gBoxCasse.Enabled = true;
            }
            else
            {
                gBoxCasse.Enabled = false;
            }

        }
        #endregion

        #region Groupe Fond
        private void FondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (FondRouge.Checked == true)
            {
                zoneTexteCible.BackColor = Color.Red;
            }
           

        }

        private void FondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (FondVert.Checked == true)
            {
                zoneTexteCible.BackColor = Color.Green;
            }
           
        }

        private void FontBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (FontBleu.Checked == true)
            {
                zoneTexteCible.BackColor = Color.Blue;
            }
          
        }

        #endregion

        #region Groupe Caractères
        private void CaraRouge_CheckedChanged(object sender, EventArgs e)
        {

            zoneTexteCible.ForeColor = Color.Red;

            //if (CaraRouge.Checked == true)
            //{
            //    zoneTexteCible.ForeColor = Color.Red;
            //}
           
        }

        private void CaraBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (CaraBlanc.Checked == true)
            {
                zoneTexteCible.ForeColor = Color.White;
            }
        }

        private void CaraNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (CaraNoir.Checked == true)
            {
                zoneTexteCible.ForeColor = Color.Black;
            }
        }

        #endregion

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
           // Le IF n'est pas nécessaire (redondance) le bouton est forcément checké
            if (radioButton9.Checked == true)
            {
                zoneTexteCible.Text = zoneTexteCible.Text.ToLower();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
            
                zoneTexteCible.Text = zoneTexteCible.Text.ToUpper();
            
        }
    }
}
