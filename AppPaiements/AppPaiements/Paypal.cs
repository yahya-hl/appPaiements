using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class paypal : paiement
    {

        public  string email {  get; set; }
        public paypal(double Montant, string Description, string email)
            : base(Montant, Description)
        {
            this.email = email;
        }
        public virtual  void AfficherDetaillsPaypal()
        {
            Console.WriteLine($"Montant : {Montant}");
            Console.WriteLine($" Description : {Description}");
            Console.WriteLine($"email : {email}");
        }
    }
}
