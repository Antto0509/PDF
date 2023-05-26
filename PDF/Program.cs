using PDF;

// Ajout des variables pour le poulailler
string nomPoulailler;
int capacitéMax;

// Ajout des variables pour la poule
string nomPoule;
string race;
int intensite;

// Instanciation d'un poulailler
Console.WriteLine("Nom du poulailler : ");
nomPoulailler = Console.ReadLine();
Console.WriteLine("Capacité maximal : ");
capacitéMax = Convert.ToInt32(Console.ReadLine());

Poulailler poulailler1 = new Poulailler(nomPoulailler, capacitéMax);

// Instanciation des poules
Console.WriteLine("Nom de la poule : ");
nomPoule = Console.ReadLine();
Console.WriteLine("La race : ");
race = Console.ReadLine();
Console.WriteLine("Intensite de la ponte : ");
intensite = Convert.ToInt32(Console.ReadLine());

Poule pouleP = new Poule(nomPoule, race, intensite, Taille.L);

//Poulailler.Ajout(pouleP);


// Affichage de ce poulailler
poulailler1.Affiche();
