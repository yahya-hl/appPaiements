using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur 
    {
        public string nom { set; get; }
        public List<Paiement> paiements { set; get; }

        public Utilisateur(string nom, List<Paiement> paiements)
        {
            this.nom = nom;
            this.paiements = new List<Paiement>() ;
        }
        public void afficherInfos()
        {
            Console.WriteLine($"nom : {nom}");
            Console.WriteLine("list de paiement : ");
            foreach (Paiement p in paiements)
            {
                p.AfficherDetaills();
            }
        }
        public void ajouterPaiement (Paiement paiement)
        {
            paiements.Add(paiement);
        }
    }
}
