namespace ClientFilm.Models
{
    /// <summary>
    /// Contiene i dati principali del film cercato.
    /// </summary>
    public class Rootobject
    {
        /// <summary>
        /// Accede o modifica i risultati della ricerca
        /// </summary>
        /// <value>
        /// Risultati della ricerca
        /// </value>
        public Search[] Search { get; set; }
        /// <summary>
        /// Accede o modifica il numero di risultati totali della ricerca
        /// </summary>
        /// <value>
        /// Numero di risultati
        /// </value>
        public string totalResults { get; set; }
        /// <summary>
        /// Accede o modifica la risposta del server
        /// </summary>
        /// <value>
        /// Risposta del server
        /// </value>
        public string Response { get; set; }
    }

    /// <summary>
    /// Contiene i dati della ricerca
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Accede o modifica il Titolo
        /// </summary>
        /// <value>
        /// Titolo del film
        /// </value>
        public string Title { get; set; }
        /// <summary>
        /// Accede o modifica l'anno
        /// </summary>
        /// <value>
        /// Anno di uscita del film
        /// </value>
        public string Year { get; set; }
        /// <summary>
        /// Accede o modifica l'id del film
        /// </summary>
        /// <value>
        /// Id del film selezionato
        /// </value>
        public string imdbID { get; set; }
        /// <summary>
        /// Accede o modifica il tipo
        /// </summary>
        /// <value>
        /// Tipologia (Serie tv, episodio, film)
        /// </value>
        public string Type { get; set; }
        /// <summary>
        /// Accede o modifica l'indirizzo della locandina
        /// </summary>
        /// <value>
        /// Indirizzo della locandina
        /// </value>
        public string Poster { get; set; }
    }
}
