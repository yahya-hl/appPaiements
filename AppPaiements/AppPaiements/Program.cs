using System;

namespace AppPaiements { 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

            Utilisateur utilisateur = new Utilisateur("yahya");
            //etape 4

            CarteCredit Carte1 = new(150.75,4666672238674564, "Matériel de randonnée");
            CarteCredit Carte2 = new(64.00,5675545364335544, "Abonnement internet ");
            CarteCredit Carte3 = new(50.45,4904835748454657, "phone");


            Carte1.AfficherDetaillscredit();
            Carte2.AfficherDetaillscredit();
            Carte3.AfficherDetaillscredit();

            //etape5

            paypal carte4 = new(54.50, "sports", "ali@gmail.com");
            paypal carte5 = new(200.00, "computer", "yahya@gmail.com");

            carte4.AfficherDetaillsPaypal();
            carte5.AfficherDetaillsPaypal();
            //etape 7
            utilisateur.AjouterPaiement(Carte1);
            utilisateur.AjouterPaiement(Carte2);
            utilisateur.AjouterPaiement(Carte3);
            utilisateur.AjouterPaiement(carte4);
            utilisateur.AjouterPaiement(carte5);

            utilisateur.AfficherInfos();

        }
}
}