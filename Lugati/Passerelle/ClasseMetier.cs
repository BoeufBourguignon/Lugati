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
    }
    /// <summary>
    /// Class
    /// <c>Session</c>
    /// </summary>
    public class Session
    {
        public int numSession, tarif, nbPlace;
        public string libelle;
        public DateTime heure, date;

        public Session(int numSession, string libelle, int tarif, int nbPlace, DateTime date, DateTime heure)
        {
            this.numSession = numSession;
            this.libelle = libelle;
            this.tarif = tarif;
            this.nbPlace = nbPlace;
            this.date = date;
            this.heure = heure;
        }
    }



}
