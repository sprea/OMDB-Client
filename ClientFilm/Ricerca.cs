﻿using System;
using System.Net.Http;
using System.Windows.Forms;
using ClientFilm.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;

namespace ClientFilm
{
    /// <summary>
    /// Classe principale della form Ricerca.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Ricerca : Form
    {
        /// <summary>
        /// Inizializza una nuova classe <see cref="Ricerca"/> class.
        /// </summary>
        public Ricerca()
        {
            InitializeComponent();
            for(int i=1895; i<=2020; i++)
            {
                AnnoBox.Items.Add(i.ToString());
            }
        }
        /// <summary>
        /// La chiave API per effettuare le richieste.
        /// </summary>
        static string ApiKey = "46bd1d1b";
        /// <summary>
        /// Le informazioni principali del film richiesto.
        /// </summary>
        Rootobject output = null;
        /// <summary>
        /// Filtri per la ricerca tipo e anno.
        /// </summary>
        string type, year;
        /// <summary>
        /// Variabili di controllo per il filtro tipologia.
        /// </summary>
        bool filtro_tipologia = false;
        /// <summary>
        /// Variabili di controllo per il filtro anno.
        /// </summary>
        bool filtro_anno = false;

        /// <summary>
        /// Metodo asincrono che effettua la ricerca nel database.
        /// </summary>
        /// <param name="sender">Oggetto source dell'evento.</param>
        /// <param name="e">L'istanza <see cref="EventArgs"/> che contiene i dati dell'evento.</param>
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Film_Table.Rows)
            {
                Film_Table.Rows.Clear();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string Ricerca, query, url;
                if (string.IsNullOrEmpty(search_textbox.Text))
                {
                    MessageBox.Show("Compila il campo di ricerca", "Errore");
                }else
                {
                    Ricerca = search_textbox.Text;

                    if(filtro_tipologia)
                    {
                        if(filtro_anno)
                        {
                            if (AnnoBox.SelectedIndex == -1)
                            {
                                MessageBox.Show("Compila i campi del filtro", "Errore");

                                query = "errore";
                            }else
                            {
                                year = AnnoBox.SelectedItem.ToString();
                            }
                        }else
                        {
                            year = null;
                        }

                        if (filmradio.Checked)
                        {
                            type = "movie";
                        }
                        else if (serieradio.Checked)
                        {
                            type = "series";
                        }

                        if(String.IsNullOrEmpty(year))
                        {
                            query = "?s=" + Ricerca + "&type=" + type + "&apikey=" + ApiKey;
                        }else
                        {
                            query = "?s=" + Ricerca + "&type=" + type + "&y=" + year + "&apikey=" + ApiKey;
                        }
                        
                    }else
                    {
                        if(filtro_anno)
                        {
                            if (AnnoBox.SelectedIndex == -1)
                            {
                                MessageBox.Show("Compila i campi del filtro", "Errore");

                                query = "errore";
                            }else
                            {
                                year = AnnoBox.SelectedItem.ToString();
                            }
                        }else
                        {
                            year = null;
                        }
                        if (String.IsNullOrEmpty(year))
                        {
                            query = "?s=" + Ricerca + "&apikey=" + ApiKey;
                        }
                        else
                        {
                            query = "?s=" + Ricerca + "&y=" + year + "&apikey=" + ApiKey;
                        }
                    }

                    AnnoBox.SelectedIndex = -1;
                    type = null;
                    year = null;
                    
                    HttpResponseMessage response = await client.GetAsync(query);

                    if(response.IsSuccessStatusCode)
                    {
                        using (WebClient web = new WebClient())
                        {
                            url = "http://www.omdbapi.com/" + query;
                            var json = web.DownloadString(url);
                            var result = JsonConvert.DeserializeObject<Rootobject>(json);
                            output = result;
                            if(output.Response == "False")
                            {
                                MessageBox.Show("Nessun film trovato", "Errore");
                            }else
                            {
                                int length = output.Search.Length;
                                int num = 1;
                                for (int i = 0; i < length; i++)
                                {
                                    output.Search[i].Year = output.Search[i].Year.Replace("â€“", "-");
                                    Film_Table.Rows.Add(num.ToString(), output.Search[i].Title, output.Search[i].Year, output.Search[i].Type);
                                    num++;
                                }
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Metodo pulsante per cancellare tutti i risultati.
        /// </summary>
        ///<param name = "sender" >Oggetto source dell'evento.</param>
        /// <param name="e">L'istanza <see cref="EventArgs"/> che contiene i dati dell'evento.</param>
        private void DeleteItems_button_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in Film_Table.Rows)
            {
                Film_Table.Rows.Clear();
            }
        }

        /// <summary>
        /// Metodo che gestisce l'evento di apertura della form Dettaglio <see cref="Dettaglio"/>
        /// </summary>
        /// <param name="sender">Oggetto source dell'evento.</param>
        /// <param name="e">L'istanza <see cref="DataGridViewCellEventArgs"/> contiene i dati della cella selezionata.</param>
        private void Film_Table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dettaglio Details = new Dettaglio();
                Details.Omdb_id = output.Search[e.RowIndex].imdbID;
                Details.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
            }
        }

        /// <summary>
        /// Metodo per il controllo del filtro dell'anno di uscita.
        /// </summary>
        /// <param name="sender">Oggetto source dell'evento.</param>
        /// <param name="e">L'istanza <see cref="EventArgs"/> che contiene i dati dell'evento.</param>
        private void YearFilter_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(YearFilter_checkbox.Checked == false)
            {
                Year_filter_box.Enabled = false;
                filtro_anno = false;
            }else
            {
                Year_filter_box.Enabled = true;
                filtro_anno = true;
            }
        }


        /// <summary>
        /// Metodo per la funzionalità di ricerca tramite tasto invio della tastiera.
        /// </summary>
        /// <param name="sender">Oggetto source dell'evento.</param>
        /// <param name="e">Parametro per l'identificazione del tasto premuto</param>
        private void search_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)   //controllo tasto invio per la ricerca
            {
                Search_btn_Click(sender, e);
            }
        }

        /// <summary>
        /// Metodo per il controllo del filtro della tipologia.
        /// </summary>
        /// <param name="sender">Oggetto source dell'evento.</param>
        /// <param name="e">L'istanza <see cref="EventArgs"/> che contiene i dati dell'evento.</param>
        private void TypeFilter_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(TypeFilter_checkbox.Checked == false)
            {
                Type_filter_box.Enabled = false;
                filtro_tipologia = false;
            }
            else
            {
                Type_filter_box.Enabled = true;
                filtro_tipologia = true;
            }
        }
    }
}
