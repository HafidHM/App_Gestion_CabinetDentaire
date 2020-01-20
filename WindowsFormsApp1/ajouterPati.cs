using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
	public partial class ajouterPati : Form
	{
		public ajouterPati()
		{
			InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        String lien;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ofd.ShowDialog())
            {
                lien = ofd.FileName;
                MessageBox.Show(lien);
                pictureBox1.ImageLocation = lien;

            }
        }
        String profil="Adulte";
        private void click_type(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                profil = "Adulte";
                radioButton2.Checked = !radioButton1.Checked;
            }
            else
            {
                profil = "Enfant";
                radioButton1.Checked = !radioButton2.Checked;
            }

        }
        String sexe= "Homme";
        private void click_sexe(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                sexe = "Homme";
                radioButton3.Checked = !radioButton4.Checked;   
            }
            else
            {
                sexe = "Femme";
                radioButton4.Checked = !radioButton3.Checked;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment ajouter "+ bunifuMaterialTextbox1.Text+" "+bunifuMaterialTextbox2.Text+ " !!","Comfirmation",MessageBoxButtons.YesNo);
            if (dr.ToString().Equals("Yes"))
            {
                Patient.ajouterPatient(new Patient(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, sexe, bunifuDatepicker1.Value, bunifuMaterialTextbox4.Text, bunifuMaterialTextbox3.Text,profil, lien, bunifuMaterialTextbox5.Text));
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";

                int n = dataGridView1.Rows.Add();
                foreach (var item in Patient.Patients)
                {
                        dataGridView1.Rows[n].Cells[0].Value = item.NomP;
                        dataGridView1.Rows[n].Cells[1].Value = item.Prenom;
                        dataGridView1.Rows[n].Cells[2].Value = item.Date_naissance;
                        dataGridView1.Rows[n].Cells[3].Value = item.Sexe;
                        dataGridView1.Rows[n].Cells[4].Value = item.Adresse;
                        dataGridView1.Rows[n].Cells[5].Value = item.Telephone;
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fic = new FileStream("BaseDedonnee", FileMode.OpenOrCreate);
                    bf.Serialize(fic, Patient.Patients);
                    fic.Close();
                }
            }
            /*   foreach (var item in Patient.Patients)
               {
                   MessageBox.Show(item.NomP);
               }
           */
        }
        private void ajouterPati_Load(object sender, EventArgs e)
        {
            foreach (var item2 in Patient.Patients)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item2.NomP;
                dataGridView1.Rows[n].Cells[1].Value = item2.Prenom;
                dataGridView1.Rows[n].Cells[2].Value = item2.Date_naissance;
                dataGridView1.Rows[n].Cells[3].Value = item2.Sexe;
                dataGridView1.Rows[n].Cells[4].Value = item2.Adresse;
                dataGridView1.Rows[n].Cells[5].Value = item2.Telephone;
            }

        }
        private void ajouterPati_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fic = new FileStream("BaseDedonnee", FileMode.OpenOrCreate);
            bf.Serialize(fic,Patient.Patients);
            fic.Close();
        }

        
    }
}
