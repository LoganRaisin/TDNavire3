namespace NavireHeritage.classesMetier
{
    using GestionNavire.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe du port.
    /// </summary>
    internal class Port
    {
        private string nom;
        private string latitude;
        private string longitude;
        private int nbPortique;
        private int nbQuaisPassager;
        private int nbQuaisTanker;
        private int nbQuaisSuperTanker;
        private Dictionary<string, Navire> navireAttendus;
        private Dictionary<string, Navire> navireArrives;
        private Dictionary<string, Navire> navirePartis;
        private Dictionary<string, Navire> navireEnAttente;

        /// <summary>
        /// Initializes a new instance of the <see cref="Port"/> class.
        /// </summary>
        /// <param name="nom">nom du port.</param>
        /// <param name="latitude">latitude du port.</param>
        /// <param name="longitude">longitude du port.</param>
        /// <param name="nbPortique">nombre de portique pour accueillir cargo.</param>
        /// <param name="nbQuaisPassager">nombre quais pour acueillir navire passagers.</param>
        /// <param name="nbQuaisTanker">nombre quai pour tankers -130000tonnes.</param>
        /// <param name="nbQuaisSuperTanker">quais tanker +130000tonnes.</param>
        /// <param name="navireAttendus">string = id des navires attendus.</param>
        /// <param name="navireArrives">navires presents dans le port.</param>
        /// <param name="navirePartis">navires partis recemment.</param>
        /// <param name="navireEnAttente">navires qui attendent un quai.</param>
        public Port(string nom, string latitude, string longitude, int nbPortique, int nbQuaisPassager, int nbQuaisTanker, int nbQuaisSuperTanker, Dictionary<string, Navire> navireAttendus, Dictionary<string, Navire> navireArrives, Dictionary<string, Navire> navirePartis, Dictionary<string, Navire> navireEnAttente)
        {
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
            this.nbPortique = nbPortique;
            this.nbQuaisPassager = nbQuaisPassager;
            this.nbQuaisTanker = nbQuaisTanker;
            this.nbQuaisSuperTanker = nbQuaisSuperTanker;
            this.navireAttendus = navireAttendus;
            this.navireArrives = navireArrives;
            this.navirePartis = navirePartis;
            this.navireEnAttente = navireEnAttente;
        }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Nom { get => this.nom; set => this.nom = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Latitude { get => this.latitude; set => this.latitude = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Longitude { get => this.longitude; set => this.longitude = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int NbPortique { get => this.nbPortique; set => this.nbPortique = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int NbQuaisPassager { get => this.nbQuaisPassager; set => this.nbQuaisPassager = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int NbQuaisTanker { get => this.nbQuaisTanker; set => this.nbQuaisTanker = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int NbQuaisSuperTanker { get => this.nbQuaisSuperTanker; set => this.nbQuaisSuperTanker = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        internal Dictionary<string, Navire> NavireAttendus { get => this.navireAttendus; set => this.navireAttendus = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        internal Dictionary<string, Navire> NavireArrives { get => this.navireArrives; set => this.navireArrives = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        internal Dictionary<string, Navire> NavirePartis { get => this.navirePartis; set => this.navirePartis = value; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        internal Dictionary<string, Navire> NavireEnAttente { get => this.navireEnAttente; set => this.navireEnAttente = value; }

        /// <summary>
        /// methode pour enregistrer arrivee prevue.
        /// </summary>
        /// <param name="navire">un navire dans le port.</param>
        public void EnregistrerArriveePrevue(Navire navire)
        {
            this.NavireAttendus.Add(navire.Imo, navire);
        }

        /// <summary>
        /// methode surcharge pour enregistrer arriver prévu.
        /// </summary>
        /// <param name="navire">navire.</param>
        public void EnregistrerArrivee(Navire navire)
        {
            if (this.NavireAttendus.ContainsKey(navire.Imo))
            {
                this.NavireArrives.Add(navire.Imo, navire);
            }
            else
            {
                throw new Exception("Le navire n'est pas attendu");
            }
        }

        /// <summary>
        /// enregistrerer navire 2.
        /// </summary>
        /// <param name="imo">num imo.</param>
        public void EnregistrerArrivee(string imo)
        {
            if (this.NavireAttendus.ContainsKey(imo))
            {
                this.NavireArrives.Add(imo, this.NavireAttendus[imo]);
            }
            else
            {
                throw new Exception("Le navire n'est pas attendu");
            }
        }

        /// <summary>
        /// methode pour enregistrer depart des navires.
        /// </summary>
        /// <param name="navire">navire.</param>
        public void EnregistrerDepart(Navire navire)
        {
            if (this.NavireArrives.ContainsKey(navire.Imo))
            {
                this.NavireArrives.Remove(navire.Imo);
            }
            else
            {
                throw new GestionPortException("le batal n'est pas dans le port.");
            }
        }

        /// <summary>
        /// Methode ajout navire.
        /// </summary>
        /// <param name="navire">navire en attente</param>
        public void AjoutNavireEnAttente(Navire navire)
        {
            if (this.NavireArrives.TryGetValue(navire.Imo, out navire))
            {

            }
        }

        /// <summary>
        /// methode est attendu.
        /// </summary>
        /// <param name="imo">imo.</param>
        public void EstAttendu(string imo)
        {

        }
    }
}
