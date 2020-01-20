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
    public partial class AjouterSeance : Form
    {
        public AjouterSeance()
        {
            InitializeComponent();
            if (pos < 0)
                pos = 0;
            else
                if(pos >= Patient.Patients.Count)
                pos = Patient.Patients.Count-1;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int pos;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            pos = Patient.Patients.Count-1;
            pictureBox2.ImageLocation = Patient.Patients[pos].LienImg;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            pos++;
            pictureBox2.ImageLocation = Patient.Patients[pos].LienImg;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            pos--;
            pictureBox2.ImageLocation = Patient.Patients[pos].LienImg;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Patient.Patients[0].LienImg;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            SalleDattente S = new SalleDattente();
            S.Show();
        }


        private void AjouterSeance_Load(object sender, EventArgs e)
        {
            int k = dataGridView1.Rows.Add();
            foreach (var item in Patient.Patients)
            {
               /* if(item.Interventions)
                {

                }
                */

            }
        }
        List<String> l = new List<String>();
        OpenFileDialog ofd = new OpenFileDialog();
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            String lien;
            if (DialogResult.OK == ofd.ShowDialog())
            {
                lien = ofd.FileName;
                pictureBox1.ImageLocation = lien;
                l.Add(lien);
            }
        }
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
          //  Seance.ajouterSeance(new Seance(,l),);
        }
       
    }
}
