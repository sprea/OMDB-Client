using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using ClientFilm.Models;

namespace ClientFilm
{
    /// <summary>
    /// Classe principale della form Dettaglio.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Dettaglio : Form
    {
        /// <summary>
        /// Inizializza una nuova classe <see cref="Dettaglio"/>.
        /// </summary>
        public Dettaglio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// L'identificatore del film.
        /// </summary>
        public string Omdb_id;
        /// <summary>
        /// La chiave API per effettuare le richieste.
        /// </summary>
        const string ApiKey = "46bd1d1b";
        /// <summary>
        /// Le informazioni del film richiesto.
        /// </summary>
        Rootobjects output;

        /// <summary>Metodo asincrono che gestisce l'apertura della form Dettaglio facendo una richiesta http al WebService.</summary>
        /// <param name="sender">Oggetto source dell'evento</param>
        /// <param name="e">L'istanza <see cref="EventArgs"/> che contiene i dati dell'evento.</param>
        private async void Dettaglio_Load(object sender, EventArgs e)
        {
            //qui si fa la chiamata al ws
            if(string.IsNullOrEmpty(Omdb_id))
            {
                MessageBox.Show("Qualcosa è andato storto", "Errore");
                this.Close();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string url;
                string query = "?i=" + Omdb_id + "&plot=full" + "&apikey=" + ApiKey;
                HttpResponseMessage response = await client.GetAsync(query);

                if (response.IsSuccessStatusCode)
                {
                    using (WebClient web = new WebClient())
                    {
                        try
                        {
                            url = "http://www.omdbapi.com/" + query;
                            var json = web.DownloadString(url);
                            var result = JsonConvert.DeserializeObject<Rootobjects>(json);
                            output = result;
                            output.Year = output.Year.Replace("â€“", "-");
                            Title_box.Text = output.Title;
                            Year_box.Text = output.Year;
                            Classification_box.Text = output.Rated;
                            ReleaseDate_box.Text = output.Released;
                            Duration_box.Text = output.Runtime;
                            Genre_box.Text = output.Genre;
                            MovieDirector_box.Text = output.Director;
                            Creators_box.Text = output.Writer;
                            Actors_box.Text = output.Actors;
                            Plot_box.Text = output.Plot;
                            ProductionCountry_box.Text = output.Country;
                            FilmPoster.ImageLocation = output.Poster;
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }else
                {
                    MessageBox.Show("Qualcosa è andato storto", "Errore");
                    this.Close();
                }
            }
        }
    }
}
