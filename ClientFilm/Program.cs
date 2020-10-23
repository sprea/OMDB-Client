using System;
using System.Configuration;
using System.Windows.Forms;

namespace ClientFilm
{
    static class Program
    {
        /// <summary>
        /// La chiave API per effettuare le richieste.
        /// </summary>
        public static string ApiKey = ConfigurationManager.AppSettings["Apikey"];

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ricerca());
        }
    }
}
