using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Intervention
	{

		private List<Seance> seances;
		private float prix;
		private String description;
        private String motif;
        private Boolean etat;
        private List<int> dents;
        private List<DateTime> RDVS;
        private Boolean terminer;
    
       
        public Intervention(float prix, string description, string motif, Boolean etat, List<int> liste_dents)
        {
           
            this.prix= prix;
            this.description = description;
            this.motif = motif;
            this.etat = etat;
            this.terminer = false;
            this.dents = liste_dents;
   
        }
        public float Prix { get => prix; set => prix = value; }
        public string Description { get => description; set => description = value; }
        public List<int> Dents { get => dents; set => dents = value; }

        public string Motif { get => motif; set => motif = value; }
        internal List<Seance> Seances { get => seances; set => seances = value; }
        public List<DateTime> RDVS1 { get => RDVS; set => RDVS = value; }
        public Boolean Etat { get => etat; set => etat = value; }
        public Boolean Terminer { get => terminer; set => terminer = value; }

        
       

        public static void ajouterPremierRDV(String nomp,DateTime rdv)
        {
            foreach (var item in Patient.Patients)
            {
                if (item.NomP.Equals(nomp))
                {
                            item.Interventions[item.Interventions.Count - 1].RDVS1.Add(rdv);
                }
            }
        }

        /*public static void ajouterAutreRDV(String nomp, DateTime rdv)
        {
            foreach (var item in Patient.Patients)
            {
                if (item.NomP.Equals(nomp))
                {
                    item.Interventions[item.Interventions.Count - 1].RDVS1.Add(rdv);

                }
            }
        }
        */


    }
}
