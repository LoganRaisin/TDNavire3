namespace NavireHeritage.classesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe nombre des passsagers.
    /// </summary>
    internal class Passager
    {
        private string numPasseport;
        private string nom;
        private string prenom;
        private string nationalite;

        /// <summary>
        /// Initializes a new instance of the <see cref="Passager"/> class.
        /// </summary>
        /// <param name="numPasseport">numero du passeport.</param>
        /// <param name="nom">nom passager.</param>
        /// <param name="prenom">prenom passager.</param>
        /// <param name="nationalite">nationalite passager.</param>
        public Passager(string numPasseport, string nom, string prenom, string nationalite)
        {
            this.numPasseport = numPasseport;
            this.nom = nom;
            this.prenom = prenom;
            this.nationalite = nationalite;
        }

        /// <summary>
        /// Gets Numero passeport.
        /// </summary>
        public string NumPasseport { get => this.numPasseport; }

        /// <summary>
        /// Gets nom.
        /// </summary>
        public string Nom { get => this.nom; }

        /// <summary>
        /// Gets prenom.
        /// </summary>
        public string Prenom { get => this.prenom; }

        /// <summary>
        /// Gets nationalite.
        /// </summary>
        public string Nationalite { get => this.nationalite; }
    }
}
