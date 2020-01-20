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
    public partial class Ajouter_intervention : Form
    {
        public Ajouter_intervention()
        {
            InitializeComponent();
        }
        
        private void Ajouter_intervention_Load(object sender, EventArgs e)
        {
            foreach (var item in Patient.Patients)
            {
                comboBox1.Items.Add(item.NomP+" "+item.Prenom);
                comboBox1.AutoCompleteCustomSource.Add(item.NomP+" "+ item.Prenom);
            }
            if (Patient.Patients[Patient.Patients.Count - 1].Type == "Enfant")
            {
                comboBox3.Visible = false;
                comboBox2.Visible = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            foreach (var item in Patient.Patients)
            {
      
                comboBox1.Focus();
                pictureBox2.ImageLocation = Patient.Patients[Patient.Patients.Count - 1].LienImg;
               comboBox1.Text = Patient.Patients[Patient.Patients.Count - 1].NomP + " " + Patient.Patients[Patient.Patients.Count - 1].Prenom;
            }
            bunifuThinButton21.Visible = false;
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

          /*  if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show(Patient.Patients[Patient.Patients.Count - 1].LienImg);
                comboBox1.Focus();

                pictureBox2.ImageLocation = Patient.Patients[Patient.Patients.Count - 1].LienImg;

            }
            */
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Ajouter_Rdv rdv = new Ajouter_Rdv();
            rdv.Show();
            this.Close();
            bunifuThinButton23.Visible = !bunifuThinButton23.Visible;
            bunifuThinButton22.Visible = !bunifuThinButton22.Visible;
            bunifuThinButton21.Visible = !bunifuThinButton22.Visible;
            this.Close();
        }
        List<int> liste = new List<int>();
        int k;
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (comboBox3.Visible)
            { k = int.Parse(comboBox3.Text); }
            else
            { k = int.Parse(comboBox2.Text); }
            liste.Add(k);
            comboBox3.Text= "";
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuThinButton23.Visible = false;
            bunifuThinButton22.Visible = true;
                Patient.ajouterIntervention(new Intervention(float.Parse(comboBox3.Text),richTextBox1.Text, comboBox4.Text, true,liste), comboBox1.Text);
            
            bunifuMaterialTextbox1.Text = "";
            richTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";

            //this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Etat