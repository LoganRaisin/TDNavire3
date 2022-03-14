﻿namespace NavireHeritage.classesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe navires.
    /// </summary>
    internal abstract class Navire
    {
        protected readonly string imo;
        protected readonly char nom;
        protected string lattitude;
        protected string longitude;
        protected int tonnageGT;
        protected int tonnageDWT;
        protected int tonnageActuel;

        /// <summary>
        /// Initializes a new instance of the <see cref="Navire"/> class.
        /// </summary>
        /// <param name="imo">matricule du bateau.</param>
        /// <param name="nom">nom du bateau.</param>
        /// <param name="lattitude">position lattitude.</param>
        /// <param name="longitude">position longitude du bateau.</param>
        /// <param name="tonnageGT">tonnage du bateau. </param>
        /// <param name="tonnageDWT">chargement max du bateau avec personnel consommables et cargaison.</param>
        /// <param name="tonnageActuel"> partie du tonnage actuelle utilisée.</param>
        protected Navire(string imo, char nom, string lattitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
        {
            this.imo = imo;
            this.nom = nom;
            this.lattitude = lattitude;
            this.longitude = longitude;
            this.tonnageGT = tonnageGT;
            this.tonnageDWT = tonnageDWT;
            this.tonnageActuel = tonnageActuel;
        }

        /// <summary>
        /// Gets Imo.
        /// </summary>
        protected string Imo { get => this.imo; }

        /// <summary>
        /// Gets nom.
        /// </summary>
        protected char Nom { get => this.nom; }

        /// <summary>
        /// Gets or sets Lattitude.
        /// </summary>
        protected string Lattitude { get => this.lattitude; set => this.lattitude = value; }

        /// <summary>
        /// Gets or sets Longitude.
        /// </summary>
        protected string Longitude { get => this.longitude; set => this.longitude = value; }

        /// <summary>
        /// Gets or sets TonnageGT.
        /// </summary>
        protected int TonnageGT { get => this.tonnageGT; set => this.tonnageGT = value; }

        /// <summary>
        /// Gets or sets TonnageDWT.
        /// </summary>
        protected int TonnageDWT { get => this.tonnageDWT; set => this.tonnageDWT = value; }

        /// <summary>
        /// Gets or sets Tonnage actuel.
        /// </summary>
        protected int TonnageActuel { get => this.tonnageActuel; set => this.tonnageActuel = value; }
    }
}
