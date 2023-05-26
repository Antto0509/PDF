using PDF;

// Ajout des variables pour le poulailler
string nomPoulailler;
int capacitéMax;

// Ajout des variables pour la poule
string nomPoule;
string race;
int intensite;
int taille;

// Instanciation d'un poulailler
Console.WriteLine("Nom du poulailler : ");
nomPoulailler = Console.ReadLine();
Console.WriteLine("Capacité maximal : ");
capacitéMax = Convert.ToInt32(Console.ReadLine());

Poulailler poulailler = new Poulailler(nomPoulailler, capacitéMax);

// Instanciation des poules
int resAjout; // Resultat lors de la demande de continuité

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

    Poule pouleP = new Poule(nomPoule, race, intensite,(Taille) taille);

    poulailler.Ajout(pouleP);

    Console.WriteLine("Vous souhaitez encore ajouter une poule ? (0 pour Non ou 1 pour Oui)");
    resAjout = Convert.ToInt32(Console.ReadLine());
} while (resAjout == 1);

// Affichage de ce poulailler
poulailler.Affiche();

// Suppression d'une poule
int pouleSupp; // L'indice de la poule à supprimer du poulailler

Console.WriteLine($"Quelle poule voulez-vous supprimer ? (donner son indice)");
pouleSupp = Convert.ToInt32(Console.ReadLine());

poulailler.Supp(pouleSupp);
poulailler.Affiche();