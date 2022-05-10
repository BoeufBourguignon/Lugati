using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lugati.dll
{
    /// <summary>
    /// Class 
    /// <c>Hebergement</c>
    /// </summary>
    public class Hebergement
    {
        public int idHebergement, nbEtoile, prix;
        public string nomHebergement, adresse, ville, cp, tel;

        public Hebergement(int idHebergement, string nomHebergement, string adresse, string ville, string cp, string tel, int nbEtoile, int prix)
        {
            this.idHebergement = idHebergement;
            this.nomHebergement = nomHebergement;
            this.adresse = adresse;
            this.ville = ville;
            this.cp = cp;
            this.tel = tel;
            this.nbEtoile = nbEtoile;
            this.prix = prix;
        }

        public override string ToString()
        {
            return this.idHebergement + " . " + this.nomHebergement;
        }
    }

    /// <summary>
    /// Class
    /// <c>Session</c>
    /// </summary>
    public class Session
    {
        public int numSession { get; set; }
        public int tarif { get; set; }
        public int nbPlaces { get; set; }
        public string libelle { get; set; }
        public DateTime date { get; set; }
        public string heure { get; set; }//Conversion heure de type "time" en type "string" pour l'affichage dans le DataGrid.
        

        public Session(int numSession, string libelle, int tarif, int nbPlaces, DateTime date, string heure)
        {
            this.numSession = numSession;
            this.libelle = libelle;
            this.tarif = tarif;
            this.nbPlaces = nbPlaces;
            this.date = date;
            this.heure = heure;
        }
    }

    /// <summary>
    /// Class
    /// <c>Activite</c>
    /// </summary>
    public class Activite
    {
        public int numActivite { get; set; }
        public int tarif { get; set; }
        public int nbPlaces { get; set; }
        public string libelle { get; set; }
        public DateTime date { get; set; }
        public string heure { get; set; } //Conversion heure de type "time" en type "string" pour l'affichage dans le DataGrid.


        public Activite() { }

        public Activite(int numActivite, string libelle, int tarif, int nbPlaces, DateTime date, string heure)
        {
            this.numActivite = numActivite;
            this.libelle = libelle;
            this.tarif = tarif;
            this.nbPlaces = nbPlaces;
            this.date = date;
            this.heure = heure;
        }
    }

    /// <summary>
    /// Class
    /// <c>Participant</c>
    /// </summary>
    public class Participant
    {
        public int idParticipant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public char genre { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string cp { get; set; }
        //public Hebergement hebergement { get; set; }
        //public Ligue ligue { get; set; }

        public int idLigue { get; set; }
        public int idHebergement { get; set; }
        public Participant() { }

        public Participant(int idParticipant, string nom, string prenom, char genre, string adresse, string ville, string cp, int idHebergement, int idLigue)
        {
            this.idParticipant = idParticipant;
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.adresse = adresse;
            this.ville = ville;
            this.cp = cp;
            this.idHebergement = idHebergement;
            this.idLigue = idLigue;
        }
    }

    /// <summary>
    /// Class
    /// <c>Ligue</c>
    /// </summary>
    public class Ligue
    {
        public int idLigue { get; set; }

        public string nomLigue { get; set; }

        public string adresse { get; set; }

        public string cp { get; set; }

        public string ville { get; set; }

        public Ligue() { }

        public Ligue(int idLigue, string nomLigue, string adresse, string cp, string ville)
        {
            this.idLigue = idLigue;
            this.nomLigue = nomLigue;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
        }

    }
}
