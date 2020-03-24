namespace ClientFilm.Models
{
    /// <summary>
    /// Contiene i dati dettagliati del film richiesto.
    /// </summary>
    public class Rootobjects
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
        /// Anno di uscita del film.
        /// </value>
        public string Year { get; set; }
        /// <summary>
        /// Accede o modifica la recensione
        /// </summary>
        /// <value>
        /// Recensione del film
        /// </value>
        public string Rated { get; set; }
        /// <summary>
        /// Accede o modifica la data di uscita
        /// </summary>
        /// <value>
        /// Data uscita del film
        /// </value>
        public string Released { get; set; }
        /// <summary>
        /// Accede o modifica la durata
        /// </summary>
        /// <value>
        /// Durata del film
        /// </value>
        public string Runtime { get; set; }
        /// <summary>
        /// Accede o modifica il genere
        /// </summary>
        /// <value>
        /// Il genere del film
        /// </value>
        public string Genre { get; set; }
        /// <summary>
        /// Accede o modifica il regista
        /// </summary>
        /// <value>
        /// Regista del film
        /// </value>
        public string Director { get; set; }
        /// <summary>
        /// Accede o modifica gli Ideatori
        /// </summary>
        /// <value>
        /// Ideatori del film
        /// </value>
        public string Writer { get; set; }
        /// <summary>
        /// Accede o modifica gli attori
        /// </summary>
        /// <value>
        /// Attori del film
        /// </value>
        public string Actors { get; set; }
        /// <summary>
        /// Accede o modifica la trama
        /// </summary>
        /// <value>
        /// Trama del film
        /// </value>
        public string Plot { get; set; }
        /// <summary>
        /// Accede o modifica la lingua
        /// </summary>
        /// <value>
        /// Lingua del film
        /// </value>
        public string Language { get; set; }
        /// <summary>
        /// Accede o modifica il paese di origine
        /// </summary>
        /// <value>
        /// Paese di origine del film
        /// </value>
        public string Country { get; set; }
        /// <summary>
        /// Accede o modifica i riconoscimenti
        /// </summary>
        /// <value>
        /// Riconoscimenti del film
        /// </value>
        public string Awards { get; set; }
        /// <summary>
        /// Accede o modifica l'indirizzo della locandina
        /// </summary>
        /// <value>
        /// Locandina del film
        /// </value>
        public string Poster { get; set; }
        /// <summary>
        /// Accede o modifica le recensioni
        /// </summary>
        /// <value>
        /// Recensioni del film
        /// </value>
        public Rating[] Ratings { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        /// <summary>
        /// Accede o modifica il tipo di film
        /// </summary>
        /// <value>
        /// Serie Tv, episodio, film
        /// </value>
        public string Type { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        /// <summary>
        /// Accede o modifica il sito web del film
        /// </summary>
        /// <value>
        /// Sito web del film
        /// </value>
        public string Website { get; set; }
        /// <summary>
        /// Accede o modifica la risposta del server
        /// </summary>
        /// <value>
        /// Risposta del server
        /// </value>
        public string Response { get; set; }
    }

    /// <summary>
    /// Classe recensione
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Accede o modifica le fonte
        /// </summary>
        /// <value>
        /// Fonte recensione
        /// </value>
        public string Source { get; set; }
        /// <summary>
        /// Accede o modifica la recensione
        /// </summary>
        /// <value>
        /// Recensione
        /// </value>
        public string Value { get; set; }
    }
}
