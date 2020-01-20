using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Seance
    {
       
        private float avence;
        private List<String> radio;
        private Ordannace ordenance;
        private String commentaire;

        public float Avence { get => avence; set => avence = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public List<string> Radio { get => radio; set => radio = value; }
  
        internal Ordannace Ordenance { get => ordenance; set => ordenance = value; }

        public Seance(string nom ,float avence,Ordannace ordenance,string commantaire,List<string> radio)
        {
            
            this.Ordenance = ordenance;
            this.Avence = avence;
            this.Commentaire = commentaire;

            foreach (var item in Patient.Patients)
            {
                int k = item.Interventions.Count;
                int b = item.Interventions[item.Interventions.Count - 1].Seances.Count;
                if (item.NomP.Equals(nom))
                {
                    for (int i = 0; i < radio.Count; i++)
                    {
                        item.Interventions[k - 1].Seances[b - 1].radio[i] = radio[i];
                    }
                }
            }
        }

        public static void ajouterSeance(Seance s, String nom)
        {
            foreach (var item in Patient.Patients)
            {
                int k = item.Interventions.Count;
                
                if (item.NomP.Equals(nom))
                {
                    item.Interventions[k - 1].Seances.Add(s);
                }
            }
        }


    }
}
