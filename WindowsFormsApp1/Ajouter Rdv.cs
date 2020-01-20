using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Ajouter_Rdv : Form
	{
		public Ajouter_Rdv()
		{
			InitializeComponent();
		}

		private void Ajouter_Rdv_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();

			foreach (var item in Patient.Patients)
			{
                comboBox1.Items.Add(item.NomP + " " + item.Prenom);
                comboBox1.AutoCompleteCustomSource.Add(item.NomP+" "+item.Prenom);

            }
            foreach (var item in Patient.Patients)
            {
                if (item.NomP.Equals(comboBox1.Text)&& (item.Interventions[item.Interventions.Count -1].Terminer == true))
                {
                    bunifuThinButton22.Visible = !bunifuThinButton22.Visible;
                }
            }

            }

		private void button1_Click(object sender, EventArgs e)
		{
			//Patient.atjouerRDV(comboBox1.Text, bunifuDatepicker1.Value);
		}

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }
        Boolean drp = false;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
            bunifuThinButton22.Visible = !bunifuThinButton22.Visible;
            foreach (var item in Patient.Patients)
            {
                if (item.NomP.Equals(comboBox1.Text))
                {
                    if (/*!(item.Interventions[item.Interventions.Count - 1].RDVS1.Count == 0) &&*/ item.Interventions[item.Interventions.Count - 1].Terminer==true)
                    {
                        drp = true;
                    }
                }
            }


          if (drp == false)
            {
                Intervention.ajouterPremierRDV(comboBox1.Text, bunifuDatepicker1.Value);
            }
          else
            {
                //autres intervention et autre RDV
                Ajouter_intervention interven = new Ajouter_intervention();
                interven.Show();
                //terminer == true;
            }
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            SalleDattente nv = new SalleDattente();
            nv.Show();
        }
    }
}

