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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in Patient.Patients)
            {
                comboBox1.Items.Add(item.NomP + " " + item.Prenom);
                comboBox1.AutoCompleteCustomSource.Add(item.NomP + " " + item.Prenom);

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            foreach (var item2 in Patient.Patients)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item2.NomP;
                dataGridView1.Rows[n].Cells[1].Value = item2.Prenom;
                dataGridView1.Rows[n].Cells[2].Value = item2.Date_naissance;
                dataGridView1.Rows[n].Cells[3].Value = item2.Sexe;
                dataGridView1.Rows[n].Cells[4].Value = item2.Adresse;
                dataGridView1.Rows[n].Cells[5].Value = item2.Assurance;
                dataGridView1.Rows[n].Cells[6].Value = item2.Telephone;

                try
                {
                    dataGridView1.Rows[n].Cells[7].Value = (Bitmap)Image.FromFile(item2.LienImg);
                }
                catch { }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView2.Visible = false;


            foreach (var item in Patient.Patients)
            {
                
                if ((item.NomP+" "+item.Prenom).Equals(comboBox1.Text))
                {
                    MessageBox.Show(" ");
                 
                    int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = item.Interventions[item.Interventions.Count - 1].Motif;
                        dataGridView2.Rows[n].Cells[1].Value = item.Interventions[item.Interventions.Count - 1].Description;
                }
                       
            }
        }
    }
}
