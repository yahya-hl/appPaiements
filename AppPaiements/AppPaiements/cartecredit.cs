namespace AppPaiements
{
    public class CarteCredit : paiement
    {

        public long numeroCarte {  get; set; }



        public CarteCredit(double Montant,long numeroCarte, string Description)
            : base(Montant,Description)
        {
            this.numeroCarte = numeroCarte;

        } 
        public  void AfficherDetaillscredit()
        {
            Console.WriteLine($"Montant : {Montant}");
            Console.WriteLine($" Description : {Description}");
            Console.WriteLine($"numero de la carte : {numeroCarte}");
        }


    }
    

}
