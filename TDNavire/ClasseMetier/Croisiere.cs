namespace NavireHeritage.classesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe croisieres.
    /// </summary>
    internal class Croisiere : Navire
    {

        private string typeNavireCroisiere;
        private int nbPassagersMaxi;
        private Dictionary<string, Passager> listePassagers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Croisiere"/> class.
        /// </summary>
        /// <param name="typeNavireCroisiere">type de croisiere.</param>
        /// <param name="nbPassagersMaxi">nombre de passager max.</param>
        /// <param name="imo">matricule du bateau.</param>
        /// <param name="nom">nom du bateau.</param>
        /// <param name="lattitude">position lattitude.</param>
        /// <param name="longitude">position longitude du bateau.</param>
        /// <param name="tonnageGT">tonnage du bateau. </param>
        /// <param name="tonnageDWT">chargement max du bateau avec personnel consommables et cargaison.</param>
        /// <param name="tonnageActuel"> partie du tonnage actuelle utilisée.</param>
        public Croisiere(string typeNavireCroisiere, int nbPassagersMaxi, string imo, string nom, string lattitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
            : base(imo, nom, lattitude, longitude, tonnageGT, tonnageDWT, tonnageActuel)
        {
            this.typeNavireCroisiere = typeNavireCroisiere;
            this.nbPassagersMaxi = nbPassagersMaxi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Croisiere"/> class.
        /// </summary>
        /// <param name="typeNavireCroisiere">type de croisiere.</param>
        /// <param name="nbPassagersMaxi">nombre de passager max.</param>
        /// <param name="listePassagers">liste des passagers.</param>
        /// <param name="imo">matricule du bateau.</param>
        /// <param name="nom">nom du bateau.</param>
        /// <param name="lattitude">position lattitude.</param>
        /// <param name="longitude">position longitude du bateau.</param>
        /// <param name="tonnageGT">tonnage du bateau. </param>
        /// <param name="tonnageDWT">chargement max du bateau avec personnel consommables et cargaison.</param>
        /// <param name="tonnageActuel"> partie du tonnage actuelle utilisée.</param>
        public Croisiere (Dictionary<string, Passager> listePassagers, string typeNavireCroisiere, int nbPassagersMaxi, string imo, string nom, string lattitude, string longitude, int tonnageGT, int tonnageDWT, int tonnageActuel)
            : base(imo, nom, lattitude, longitude, tonnageGT, tonnageDWT, tonnageActuel) { this.listePassagers = listePassagers; }

        /// <summary>
        /// Gets or sets typeNavireCroisiere.
        /// </summary>
        protected string TypeNavireCroisiere
        {
            get => this.typeNavireCroisiere;
            set
            {
                if (value == "V" || value == "M")
                {
                    this.typeNavireCroisiere = value;
                }
            }
        }

        /// <summary>
        /// Gets nbPassagersMaxi.
        /// </summary>
        protected int NbPassagersMaxi { get => this.nbPassagersMaxi; }

        /// <summary>
        /// Gets ListePassagers.
        /// </summary>
        protected Dictionary<string, Passager> ListePassagers { get => this.listePassagers; }

        /// <summary>
        /// methode embarquer.
        /// </summary>
        /// <param name="lesPassagers">liste des passagers qui embarquent.</param>
        public void Embarquer(List<Passager> lesPassagers)
        {
            if (lesPassagers.Count <= this.NbPassagersMaxi - this.listePassagers.Count)
            {
                foreach (Passager passager in lesPassagers)
                {
                    this.listePassagers.Add(passager.NumPasseport, passager);
                }
            }
            else
            {
                throw new Exception("Aucun des passagers ne sera ajouté car pas assez de place.");
            }
        }

        /// <summary>
        /// methode pour debarquement.
        /// </summary>
        /// <param name="lesPassagersPresents">passager presents dans bateau.</param>
        public void Debarquer(List<Passager> lesPassagersPresents)
        {
            if (lesPassagersPresents.Count <= this.listePassagers.Count)
            {
                foreach (Passager passager in lesPassagersPresents)
                {
                    this.listePassagers.Remove(passager.NumPasseport);
                }
            }
            else
            {
                throw new Exception("liste plu grande que le nombre de passager présent");
            }
        }
    }
}
