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
            Console.WriteLine($"Dans le poulailler {nom} de capacité maximal {capacitéMax} il y a :");
            for (int i = 0; i < poule.Count(); i++)
            {
                Console.WriteLine($"Poule {i} : {poule[i]}");
                
            }
            Console.WriteLine(poule.Count());
        }
    }
}
