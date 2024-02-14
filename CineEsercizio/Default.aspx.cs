using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineEsercizio
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Sala1_Click(object sender, EventArgs e)
        {
            // Tramite il nome della stringa di connessione in web.config (Cinema) la recupero!
            string connectionString = ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString.ToString();
            //Tramite la classe SqlConnection creo la connessione:
            SqlConnection conn = new SqlConnection(connectionString);
            //Try = in cui apro la connessione
            // per prova stampiamo il messaggio di successo
            // in questo try facciamo la query per stampare i dati delle prenotazioni nei p giusti (SalaNord, SalaEst, SalaSud)
            try
            {
                conn.Open(); // apro la connessione con il db
                Response.Write(conn.State); //messaggio provvisorio per il feedback
                Response.Write("Connessione riuscita");
            }
            // Catch = Se non avviene la connessione e7o ci sono eccezioni
            catch
            {
                Response.Write("Connessione fallita");
            }
            // Finally = Chiudo la connessione
            finally {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void Sala2_Click(object sender, EventArgs e)
        {
            // Tramite il nome della stringa di connessione (Cinema) la recupero!
            string connectionString = ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString.ToString();
            //Tramite la classe SqlConnection creo la connessione:
            SqlConnection conn = new SqlConnection(connectionString);
            //Try = in cui apro la connessione
            // per prova stampiamo il messaggio di successo
            // in questo try facciamo la query per stampare i dati delle prenotazioni nei p giusti (SalaNord, SalaEst, SalaSud)
            try
            {
                conn.Open(); // apro la connessione con il db
                Response.Write(conn.State); //messaggio provvisorio per il feedback
                Response.Write("Connessione riuscita");
            }
            // Catch = Se non avviene la connessione e7o ci sono eccezioni
            catch
            {
                Response.Write("Connessione fallita");
            }
            // Finally = Chiudo la connessione
            finally {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void Sala3_Click(object sender, EventArgs e)
        {
            // Tramite il nome della stringa di connessione (Cinema) la recupero!
            string connectionString = ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString.ToString();
            //Tramite la classe SqlConnection creo la connessione:
            SqlConnection conn = new SqlConnection(connectionString);
            //Try = in cui apro la connessione
            // per prova stampiamo il messaggio di successo
            // in questo try facciamo la query per stampare i dati delle prenotazioni nei p giusti (SalaNord, SalaEst, SalaSud)
            try
            {
                conn.Open(); // apro la connessione con il db
                Response.Write(conn.State); //messaggio provvisorio per il feedback
                Response.Write("Connessione riuscita");
            }
            // Catch = Se non avviene la connessione e7o ci sono eccezioni
            catch
            {
                Response.Write("Connessione fallita");
            }
            // Finally = Chiudo la connessione
            finally {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}