namespace GestionNavire.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// classe gestion des exceptions du port.
    /// </summary>
    internal class GestionPortException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GestionPortException"/> class.
        /// </summary>
        /// <param name="message">message renvoyé à l'exception.</param>
        public GestionPortException(string message)
            : base("Erreur de : " + Environment.UserName + " le " + DateTime.Now.ToLocalTime() + "\n" + message) { }
    }
}
