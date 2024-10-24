namespace AppPaiements { 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
            //etape 4

            CarteCredit Carte1 = new(4666672238674564, 150.75, "Matériel de randonnée");
            CarteCredit Carte2 = new(5675545364335544, 64.00, "Abonnement internet ");
            CarteCredit Carte3 = new(4904835748454657, 50.45, "phone");

            Carte1.AfficherDetaillscredit();
            Carte2.AfficherDetaillscredit();
            Carte3.AfficherDetaillscredit();

            //etape5

            Paypal carte4 = new(54.50, "sports", "ali@gmail.com");
            Paypal carte5 = new(200.00, "computer", "yahya@gmail.com");

            carte4.AfficherDetaillsPaypal();
            carte5.AfficherDetaillsPaypal();





        }
}
}