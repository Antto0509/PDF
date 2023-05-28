using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    /// <summary>
    /// Modélise un poulailler
    /// </summary>
    public class Poulailler
    {
        /// <summary>
        /// Nom du poulailler
        /// </summary>
        string nom;
        /// <summary>
        /// Capacité maximal du poulailler
        /// </summary>
        /// <example>10, 20, 30, 40</example>
        int capacitéMax;
        /// <summary>
        /// Poule correspondant au poulailler
        /// </summary>
        List<Poule> poule = new List<Poule>();

        /// <summary>
        /// Création d'une nouvelle instance d'un poulailler
        /// </summary>
        /// <param name="nomPoulailler">Nom</param>
        /// <param name="capacitéMaxPoulailler">Capacité Maximal</param>
        public Poulailler(string nomPoulailler, int capacitéMaxPoulailler)
        {
            nom = nomPoulailler;
            capacitéMax = capacitéMaxPoulailler;
        }

        public void Ajout(Poule pouleP)
        {
            poule.Add(pouleP);
        }

        public void Affiche()
        {
            Console.WriteLine($"Le poulailler : {nom}");
            Console.WriteLine($"Capacité maximal : {capacitéMax}");
            for (int i = 0; i < poule.Count(); i++)
            {
                Console.WriteLine($"Poule {i + 1} : ");
                poule[i].Afficher();
                
            }
            Console.WriteLine($"Le nombre de poule(s) : {poule.Count()}");
        }

        public void Supp(int pouleSupp)
        {
            for (int i = 0; i < poule.Count() ; i++) 
            { 
                if (i+1 == pouleSupp)
                {
                    poule.RemoveAt(i);
                }
            }
        }

        public void SuppPoulailler()
        {
            poule.Clear();
        }
    }
}
