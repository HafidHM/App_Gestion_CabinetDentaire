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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            MDIParent1 m = new MDIParent1();
            if (comboBox1.Text == "ok")
            {
                m.Testi = 1;
            }
            m.Show();
            this.Hide();
        }
    }
  }

