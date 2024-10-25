using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public List<paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        {
            this.Nom = nom;
            this.Paiements = new List<paiement>();
        }

        public  void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine("Liste des paiements : ");
            foreach (paiement p in Paiements)
            {
                p.AfficherDetaills();  
            }
        }

        public  void AjouterPaiement(paiement p)
        {
            Paiements.Add(p);
        }
    }

}
