using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
    class Patient
	{
		private String nomP;
        private String prenom;
        private String sexe;
        private DateTime date_naissance;
        private String telephone;
        private String adresse;
        private String type;
        private String assurance;
        private String lienImg;
        private List<Intervention> interventions; 
		public static List<Patient> Patients = new List<Patient>();

		public string NomP { get => nomP; set => nomP = value; }
		internal List<Intervention> Interventions { get => interventions; set => interventions = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Type { get => type; set => type = value; }
        public string LienImg { get => lienImg; set => lienImg = value; }
        public string Assurance { get => assurance; set => assurance = value; }

        public Patient(String nom)
        {
            this.NomP = nom;
        }

        public Patient(string nomP, string prenom, string sexe, DateTime date_naissance, string telephone, string adresse,string type,string lienImg,string assurance)
        {
            this.nomP = nomP;
            this.prenom = prenom;
            this.sexe = sexe;
            this.date_naissance = date_naissance;
            this.telephone = telephone;
            this.adresse = adresse;
            this.type = type;
            this.lienImg = lienImg;
            this.assurance = assurance;
        }
        public static void ajouterPatient(Patient p)
		{
            Patient.Patients.Add(p);
		}

		public static void ajouterIntervention(Intervention v, String nomp)
		{
            foreach (var item in Patient.Patients)
            {
                if ((item.NomP+" "+item.Prenom).Equals(nomp))
                {
                        item.interventions.Add(v);
                }
            }
        }
        /*

		public static void atjouerRDV(String nomP, DateTime dateRDV) {
			Seance s = new Seance();
			s.RdvSeance = dateRDV;
			for (int i = 0; i < Patients.Count; i++)
				if (Patients[i].nomP.Equals(nomP))
						Patients[i].ajouterSeance(s);
		}
		public void donneeOrdannace(Ordannace o)
		{
			int der_int = Interventions.Count - 1;
			int der_sea = this.interventions[der_int].Seances.Count - 1;
			this.interventions[der_int].Seances[der_sea].Ordannace = o;
		}

		

		public void save() { }
		public void load() { }
    */

    }
}
