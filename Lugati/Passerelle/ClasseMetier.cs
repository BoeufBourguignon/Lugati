﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passerelle
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
        public DateTime heure { get; set; }
        public DateTime date { get; set; }

        public Session(int numSession, string libelle, int tarif, int nbPlaces, DateTime date, DateTime heure)
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
        public int nbPlace { get; set; }
        public string libelle { get; set; }
        public DateTime heure { get; set; }
        public DateTime date { get; set; }

        public Activite() { }

        public Activite(int numActivite, string libelle, int tarif, int nbPlace, DateTime date, DateTime heure)
        {
            this.numActivite = numActivite;
            this.libelle = libelle;
            this.tarif = tarif;
            this.nbPlace = nbPlace;
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
        public Hebergement hebergement { get; set; }
        public Ligue ligue { get; set; }

        public Participant() { }

        public Participant(int idParticipant, string nom, string prenom, char genre, string adresse, string ville, string cp, Hebergement hebergement, Ligue ligue)
        {
            this.idParticipant = idParticipant;
            this.nom = nom;
            this.prenom = prenom;
            this.genre = genre;
            this.adresse = adresse;
            this.ville = ville;
            this.cp = cp;
            this.hebergement = hebergement;
            this.ligue = ligue;
        }
    }

    public class Ligue
    {
        //TODO (Gaby)
    }



}
