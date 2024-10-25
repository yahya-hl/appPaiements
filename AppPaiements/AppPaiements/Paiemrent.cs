using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class paiement
    {
        public double Montant { get; set; }
        public string Description { get; set; }

        public paiement(double Montant, string Description)
        {
            this.Montant = Montant;
            this.Description = Description;

        }

        public  void AfficherDetaills()
        {
            Console.WriteLine($"Montant : {Montant}");
            Console.WriteLine($" Description : {Description}");





        }
    }

    
}
