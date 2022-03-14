namespace NavireHeritage.classesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe tankers.
    /// </summary>
    internal class Tanker : Navire
    {
        private string typeFLuide;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tanker"/> class.
        /// </summary>
        /// <param name="typeFluide">type fluide transporté.</param>
        /// <param name="imo">matricule du bateau.</param>
        /// <param name="nom">nom du bateau.</param>
        /// <param name="lattitude">position lattitude.</param>
        /// <param name="longitude">position longitude du bateau.</param>
        /// <param name="tonnageGT">tonnage du bateau. </param>
        /// <param name="tonnageDWT">chargement max du bateau avec personnel consommables et cargaison.</param>
        /// <param name="tonnageActuel"> partie du tonnage actuelle utilisée.</param>
        public Tanker(string typeFluide, string imo, string nom, string lattitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
            : base(imo, nom, lattitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
        }

        /// <summary>
        /// Gets typefluide.
        /// </summary>
        protected string TypeFLuide { get => this.typeFLuide; }

        /// <summary>
        /// methode pour charger.
        /// </summary>
        /// <param name="nombre">tonnes que l'on charge.</param>
        public void Charger(int nombre)
        {
            if (this.tonnageActuel + nombre <= this.tonnageDWT)
            {
                this.tonnageDWT += nombre;
            }
            else
            {
                throw new Exception("Le bateau ne peut pas accueillir autant de marchandise.");
            }
        }

        /// <summary>
        /// methode pour decharger bateau.
        /// </summary>
        /// <param name="nombre">quantité dechargée.</param>
        public void Decharger(int nombre)
        {
            if (this.tonnageActuel - nombre >= 0)
            {
                this.tonnageActuel -= nombre;
            }
            else
            {
                throw new Exception("Le bateau a moins que la quantité annoncée.");
            }
        }
    }
}
