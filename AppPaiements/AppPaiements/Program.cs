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

            Carte1.AfficherDetaills();
            Carte2.AfficherDetaills();
            Carte3.AfficherDetaills();






        }
}
}