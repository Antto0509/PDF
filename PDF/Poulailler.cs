using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
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
        Poule poule;


        /// <summary>
        /// Création d'une nouvelle instance d'un poulailler
        /// </summary>
        /// <param name="nomPoulailler">Nom</param>
        /// <param name="capacitéMaxPoulailler">Capacité Maximal</param>
        /// <param name="poulePoulailler">Poule</param>
        public Poulailler(string nomPoulailler, int capacitéMaxPoulailler, Poule poulePoulailler)
        {
            nom = nomPoulailler;
            capacitéMax = capacitéMaxPoulailler;
            poule = poulePoulailler;
        }

        public void Affiche()
        {
            for (int i = 0; i <  ; i++)
            {
                Console.WriteLine($"{nom} {capacitéMax} {poule}");
            }
        }
    }
}
