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
	public partial class MDIParent1 : Form
	{
		private int childFormNumber = 0;

		public MDIParent1()
		{
			InitializeComponent();
            //this.Hide();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Fenêtre " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void ajouterPatientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ajouterPati p = new ajouterPati();
			p.MdiParent = this;
            p.Show();
		}

		private void consultertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2();
			f.MdiParent = this;
			f.Show();
		}

		private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private int testi=0;

		public int Testi { get => testi; set => testi = value; }

		private void MDIParent1_Load(object sender, EventArgs e)
		{
			if (testi != 0)
			{
				medecinToolStripMenuItem.Visible = true;
			}

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fic = new FileStream("BaseDedonnee", FileMode.OpenOrCreate);
            if (fic.Length > 0)

                Patient.Patients = (List<Patient>)bf.Deserialize(fic);

            fic.Close();

        }

		private void ajouterRdvToolStripMenuItem_Click(object sender, EventArgs e)
		{

			Ajouter_Rdv f = new Ajouter_Rdv();
			f.MdiParent = this;
			f.Show();
		}

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fic = new FileStream("BaseDedonnee", FileMode.OpenOrCreate);
            bf.Serialize(fic, Patient.Patients);
            fic.Close();
        }

        private void ajouterIntervebntonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Ajouter_intervention f = new Ajouter_intervention();
            f.MdiParent = this;
            f.Show();
        }

        private void confirmerSeanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSeance f = new AjouterSeance();
            f.MdiParent = this;
            f.Show();
        }

        private void salleDatteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalleDattente f = new SalleDattente();
            f.MdiParent = this;
            f.Show();
        }
    }
}
