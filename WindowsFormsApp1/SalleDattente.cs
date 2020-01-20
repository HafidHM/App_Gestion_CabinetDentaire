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
    public partial class SalleDattente : Form
    {
        public SalleDattente()
        {
            InitializeComponent();
        }

        private void SalleDattente_Load(object sender, EventArgs e)
        {
            foreach (var item2 in Patient.Patients)
            {
                        foreach (var item in item2.Interventions)
                        {
                            if(item.RDVS1.Count != 0)
                             {
                                    int n = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[n].Cells[0].Value = item2.NomP;
                                    dataGridView1.Rows[n].Cells[1].Value = item2.Prenom;
                                    dataGridView1.Rows[n].Cells[2].Value = item.RDVS1[item.RDVS1.Count - 1];
                                    try
                                    {
                                        dataGridView1.Rows[n].Cells[3].Value = (Bitmap)Image.FromFile(item2.LienImg);
                                    }
                                    catch { }
                             }
                               
                        } 
            }
        }
    }
}
