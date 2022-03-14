namespace NavireHeritage.classesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe des cargots.
    /// </summary>
    internal class Cargo : Navire
    {
        private string typeFret;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cargo"/> class.
        /// </summary>
        /// <param name="typeFret">type du bateau.</param>
        /// <param name="imo">matricule du bateau.</param>
        /// <param name="nom">nom du bateau.</param>
        /// <param name="lattitude">position lattitude.</param>
        /// <param name="longitude">position longitude du bateau.</param>
        /// <param name="tonnageGT">tonnage du bateau. </param>
        /// <param name="tonnageDWT">chargement max du bateau avec personnel consommables et cargaison.</param>
        /// <param name="tonnageActuel"> partie du tonnage actuelle utilisée.</param>
        public Cargo(string typeFret, string imo, string nom, string lattitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
            : base (imo, nom, lattitude, longitude,tonnageGT, tonnageDWT, tonnageActuel)
        {
            this.typeFret = typeFret;
        }

        /// <summary>
        /// Gets typeFret.
        /// </summary>
        public string TypeFret { get => this.typeFret; }

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
