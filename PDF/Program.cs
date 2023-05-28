using PDF;

// Ajout des variables pour le poulailler
string nomPoulailler;
int capacitéMax;

// Ajout des variables pour la poule
string nomPoule;
string race;
int intensite;
int taille;

int resAjout; // Resultat lors de la demande de continuité

// Instanciation d'un poulailler
Console.WriteLine("Nom du poulailler : ");
nomPoulailler = Console.ReadLine();
Console.WriteLine("Capacité maximal : ");
capacitéMax = Convert.ToInt32(Console.ReadLine());

Poulailler poulailler = new Poulailler(nomPoulailler, capacitéMax);

// Instanciation des poules
do
{
    Console.WriteLine("Nom de la poule : ");
    nomPoule = Console.ReadLine();
    Console.WriteLine("La race : ");
    race = Console.ReadLine();
    Console.WriteLine("Intensite de la ponte : ");
    intensite = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Taille de la poule (S = 0, M = 1, L = 2, Xl = 3, XXl = 4): ");
    taille = Convert.ToInt32(Console.ReadLine());

    Poule pouleP = new Poule(nomPoule, race, intensite, (Taille)taille);

    poulailler.Ajout(pouleP);

    Console.WriteLine("Vous souhaitez encore ajouter une poule ? (0 pour Non ou 1 pour Oui)");
    resAjout = Convert.ToInt32(Console.ReadLine());
} while (resAjout == 1);


// Affichage de ce poulailler
poulailler.Affiche();

// Suppression d'une poule
int pouleSupp; // L'indice de la poule à supprimer du poulailler

Console.WriteLine("\nVous souhaitez supprimer une poule ? (0 pour Non ou 1 pour Oui)");
int resSupp = Convert.ToInt32(Console.ReadLine()); // Resultat lors de la demande de suppression

if (resSupp == 1)
{
    Console.WriteLine($"Quelle poule voulez-vous supprimer ? (donner son indice)");
    pouleSupp = Convert.ToInt32(Console.ReadLine());

    poulailler.Supp(pouleSupp);
    poulailler.Affiche();
}

// Suppression d'un poulailler
Console.WriteLine("\nVous souhaitez supprimer toutes les poules d'un poulailler ? (0 pour Non ou 1 pour Oui)");
int resSuppPoulailler = Convert.ToInt32(Console.ReadLine()); // Resultat lors de la demande de suppression


if (resSuppPoulailler == 1)
{
    poulailler.SuppPoulailler();
    poulailler.Affiche();
}