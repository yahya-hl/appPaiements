namespace AppPaiements
{
    public class CarteCredit : Paiement
    {

        public long numeroCarte {  get; set; }



        public CarteCredit(long numeroCarte, double Montant, string Description)
            : base(Montant,Description)
        {
            this.numeroCarte = numeroCarte;

        } 
        public new void AfficherDetaills()
        {
            Console.WriteLine($"Montant : {Montant}");
            Console.WriteLine($" Description : {Description}");
            Console.WriteLine($"numero de la carte : {numeroCarte}");
        }


    }
    

}
