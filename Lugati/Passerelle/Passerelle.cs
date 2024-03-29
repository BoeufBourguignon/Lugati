﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;


namespace Lugati.dll
{
    public static class Passerelle
    {
        #region Chaine de Connexion //////////////////////////////////////////////////////
        private static SqlConnection connexionBaseLugati = new SqlConnection(
            "Data Source=" + Environment.MachineName.ToString() + ";" +
            "Initial Catalog=base_lugati;" +
            "User Id=LugatiApp;" +
            "Password=b4n4n3");
        #endregion


        #region Sessions /////////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne toutes les sessions
        /// </summary>
        public static List<Session> GetLesSessions()
        {
            List<Session> lesSessions = new List<Session>();

            SqlCommand reqLesSessions = new SqlCommand(
                "SELECT numSession, libelle, tarif, nbPlaces, date, heure " +
                "FROM Session",
                Passerelle.connexionBaseLugati);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesSessions = reqLesSessions.ExecuteReader();

                if (readerLesSessions.HasRows)
                {
                    while (readerLesSessions.Read())
                    {
                        lesSessions.Add(new Session(
                                (int)readerLesSessions[0],
                                readerLesSessions[1].ToString(),
                                (int)readerLesSessions[2],
                                (int)readerLesSessions[3],
                                Convert.ToDateTime(readerLesSessions[4]),
                                (readerLesSessions[5].ToString())));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesSessions;
        }

        /// <summary>
        /// Retourne toutes les sessions disponibles pour un participant
        /// C'est à dire celles où il n'est pas inscrit et où il reste de la place disponible
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        public static List<Session> GetLesSessionsDisponibles(int idParticipant)
        {
            List<Session> lesS = new List<Session>();

            SqlCommand reqLesSessions = new SqlCommand(
                "SELECT s.numSession, s.libelle, s.tarif, s.nbPlaces, s.date, s.heure " +
                "FROM session s " +
                "  LEFT JOIN inscrire i on i.numSession = s.numSession " +
                "WHERE NOT EXISTS (SELECT * FROM inscrire i2 WHERE i.numSession = i2.numSession AND i2.idParticipant = @idParticipant) " +
                "GROUP BY s.numSession, s.libelle, s.tarif, s.nbPlaces, s.date, s.heure " +
                "HAVING count(idParticipant) < s.nbPlaces",
                Passerelle.connexionBaseLugati);
            reqLesSessions.Parameters.AddWithValue("@idParticipant", idParticipant);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesSessions = reqLesSessions.ExecuteReader();
                if(readerLesSessions.HasRows)
                {
                    while(readerLesSessions.Read()) {
                        lesS.Add(new Session(
                                (int)readerLesSessions[0],
                                readerLesSessions[1].ToString(),
                                (int)readerLesSessions[2],
                                (int)readerLesSessions[3],
                                Convert.ToDateTime(readerLesSessions[4]),
                                (readerLesSessions[5].ToString())));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesS;
        }

        /// <summary>
        /// Retourne toutes les sessions dans lesquelles un participant est inscrit
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        public static List<Session> GetLesSessionsInscrites(int idParticipant)
        {
            List<Session> lesS = new List<Session>();

            SqlCommand reqLesSessions = new SqlCommand(
                "SELECT s.numSession, s.libelle, s.tarif, s.nbPlaces, s.date, s.heure " +
                "FROM session s " +
                "  JOIN inscrire i on i.numSession = s.numSession " +
                "WHERE idParticipant = @idParticipant",
                Passerelle.connexionBaseLugati);
            reqLesSessions.Parameters.AddWithValue("@idParticipant", idParticipant);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesSessions = reqLesSessions.ExecuteReader();
                if (readerLesSessions.HasRows)
                {
                    while (readerLesSessions.Read())
                    {
                        lesS.Add(new Session(
                                (int)readerLesSessions[0],
                                readerLesSessions[1].ToString(),
                                (int)readerLesSessions[2],
                                (int)readerLesSessions[3],
                                Convert.ToDateTime(readerLesSessions[4]),
                                (readerLesSessions[5].ToString())));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesS;
        }

        /// <summary>
        /// Ajoute une session à la base de données
        /// </summary>
        /// <param name="s">Objet de la session à ajouter</param>
        /// <returns>Identifiant de la session ajoutée</returns>
        public static int AjouterSession(Session s)
        {
            SqlCommand reqAjouterSession =
                new SqlCommand("INSERT INTO Session (libelle, tarif, nbPlaces, date, heure) " +
                                "OUTPUT INSERTED.numSession " +
                                "VALUES (@libelle, @tarif, @nbPlaces, @date, @heure)",
                Passerelle.connexionBaseLugati);
            reqAjouterSession.Parameters.AddWithValue("@libelle", s.libelle);
            reqAjouterSession.Parameters.AddWithValue("@tarif", s.tarif);
            reqAjouterSession.Parameters.AddWithValue("@nbPlaces", s.nbPlaces);
            reqAjouterSession.Parameters.AddWithValue("@date", s.date);
            reqAjouterSession.Parameters.AddWithValue("@heure", s.heure);

            int id = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();

                id = (int)reqAjouterSession.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return id;
        }

        /// <summary>
        /// Supprime une session de la base de données
        /// </summary>
        /// <param name="numSession">Identifiant de la session à supprimer</param>
        /// <returns>false si des participants sont déjà inscrits</returns>
        public static bool SupprimerSession(int numSession)
        {
            bool peutEtreSupprime = false;

            //D'abord on vérifie que la session peut être supprimée
            //C'est à dire qu'elle ne fait pas l'objet d'inscriptions
            SqlCommand reqPeutEtreSupprime = new SqlCommand(
                "SELECT count(*) FROM inscrire WHERE numSession = @num",
                Passerelle.connexionBaseLugati);
            reqPeutEtreSupprime.Parameters.AddWithValue("@num", numSession);

            int nbInscris = 0;
            try
            {
                Passerelle.connexionBaseLugati.Open();

                nbInscris = (int)reqPeutEtreSupprime.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            //Si la session n'a pas d'inscrits, on peut la supprimer
            if (nbInscris == 0)
            {
                peutEtreSupprime = true;

                SqlCommand reqSupprimerActivite = new SqlCommand(
                    "DELETE FROM Session WHERE numSession = @num",
                    Passerelle.connexionBaseLugati);
                reqSupprimerActivite.Parameters.AddWithValue("@num", numSession);

                try
                {
                    Passerelle.connexionBaseLugati.Open();

                    reqSupprimerActivite.ExecuteNonQuery();
                }
                finally
                {
                    Passerelle.connexionBaseLugati.Close();
                }
            }

            return peutEtreSupprime;
        }

        /// <summary>
        /// Modifie une session dans la base de données
        /// </summary>
        /// <param name="s">Objet de la session à modifier</param>
        public static void ModifierSession(Session s)
        {
            SqlCommand reqModifierSession = new SqlCommand(
                "UPDATE Session " +
                "SET libelle = @libelle, " +
                "    tarif = @tarif, " +
                "    nbPlaces = @nbPlaces, " +
                "    date = @date, " +
                "    heure = @heure " +
                "WHERE numSession = @numSession",
                Passerelle.connexionBaseLugati);
            reqModifierSession.Parameters.AddWithValue("@libelle", s.libelle);
            reqModifierSession.Parameters.AddWithValue("@tarif", s.tarif);
            reqModifierSession.Parameters.AddWithValue("@nbPlaces", s.nbPlaces);
            reqModifierSession.Parameters.AddWithValue("@date", s.date);
            reqModifierSession.Parameters.AddWithValue("@heure", s.heure);
            reqModifierSession.Parameters.AddWithValue("@numSession", s.numSession);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqModifierSession.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        #endregion


        #region Activites ////////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne toutes les activités
        /// </summary>
        public static List<Activite> GetLesActivites()
        {
            List<Activite> lesActivites = new List<Activite>();

            SqlCommand reqLesActivites = new SqlCommand(
                "SELECT numActivite, libelle, tarif, nbPlaces, date, heure " +
                "FROM Activite",
                Passerelle.connexionBaseLugati);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesActivites = reqLesActivites.ExecuteReader();

                if (readerLesActivites.HasRows)
                {
                    while (readerLesActivites.Read())
                    {
                        lesActivites.Add(new Activite(
                                (int)readerLesActivites[0],
                                readerLesActivites[1].ToString(),
                                (int)readerLesActivites[2],
                                (int)readerLesActivites[3],
                                Convert.ToDateTime(readerLesActivites[4]),
                                readerLesActivites[5].ToString()));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesActivites;
        }

        /// <summary>
        /// Retourne toutes les activités disponibles pour un participant
        /// C'est à dire celles où il n'est pas inscrit et où il reste de la place disponible
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        public static List<Activite> GetLesActivitesDisponibles(int idParticipant)
        {
            List<Activite> lesA = new List<Activite>();

            SqlCommand reqLesActivites = new SqlCommand(
                "SELECT a.numActivite, a.libelle, a.tarif, a.nbPlaces, a.date, a.heure " +
                "FROM activite a " +
                "  LEFT JOIN participer p on p.numActivite = a.numActivite " +
                "WHERE NOT EXISTS (SELECT * FROM participer p2 WHERE p.numActivite = p2.numActivite AND p2.idParticipant = @idParticipant) " +
                "GROUP BY a.numActivite, a.libelle, a.tarif, a.nbPlaces, a.date, a.heure " +
                "HAVING count(idParticipant) < a.nbPlaces",
                Passerelle.connexionBaseLugati);
            reqLesActivites.Parameters.AddWithValue("@idParticipant", idParticipant);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesActivites = reqLesActivites.ExecuteReader();
                if (readerLesActivites.HasRows)
                {
                    while (readerLesActivites.Read())
                    {
                        lesA.Add(new Activite(
                                (int)readerLesActivites[0],
                                readerLesActivites[1].ToString(),
                                (int)readerLesActivites[2],
                                (int)readerLesActivites[3],
                                Convert.ToDateTime(readerLesActivites[4]),
                                (readerLesActivites[5].ToString())));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesA;
        }

        /// <summary>
        /// Retourne toutes les activités dans lesquelles un participant est inscrit
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        public static List<Activite> GetLesActivitesInsrites(int idParticipant)
        {
            List<Activite> lesA = new List<Activite>();

            SqlCommand reqLesActivites = new SqlCommand(
                "SELECT a.numActivite, a.libelle, a.tarif, a.nbPlaces, a.date, a.heure " +
                "FROM activite a " +
                "  JOIN participer p on p.numActivite = a.numActivite " +
                "WHERE idParticipant = @idParticipant",
                Passerelle.connexionBaseLugati);
            reqLesActivites.Parameters.AddWithValue("@idParticipant", idParticipant);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesActivites = reqLesActivites.ExecuteReader();
                if (readerLesActivites.HasRows)
                {
                    while (readerLesActivites.Read())
                    {
                        lesA.Add(new Activite(
                                (int)readerLesActivites[0],
                                readerLesActivites[1].ToString(),
                                (int)readerLesActivites[2],
                                (int)readerLesActivites[3],
                                Convert.ToDateTime(readerLesActivites[4]),
                                (readerLesActivites[5].ToString())));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesA;
        }

        /// <summary>
        /// Ajoute une activité à la base de données
        /// </summary>
        /// <param name="a">Objet de l'activité à ajouter</param>
        /// <returns>Identifiant de l'activité ajoutée</returns>
        public static int AjouterActivite(Activite a)
        {
            SqlCommand reqAjouterActivite = new SqlCommand(
                "INSERT INTO Activite (libelle, tarif, nbPlaces, date, heure) " +
                "OUTPUT INSERTED.numActivite " +
                "VALUES (@libelle, @tarif, @nbPlaces, @date, @heure)",
                Passerelle.connexionBaseLugati);
            reqAjouterActivite.Parameters.AddWithValue("@libelle", a.libelle);
            reqAjouterActivite.Parameters.AddWithValue("@tarif", a.tarif);
            reqAjouterActivite.Parameters.AddWithValue("@nbPlaces", a.nbPlaces);
            reqAjouterActivite.Parameters.AddWithValue("@date", a.date);
            reqAjouterActivite.Parameters.AddWithValue("@heure", a.heure);

            int id = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();

                id = (int)reqAjouterActivite.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return id;
        }

        /// <summary>
        /// Supprime une activité de la base de données
        /// </summary>
        /// <param name="numActivite">Identifiant de l'activité à supprimer</param>
        /// <returns>false si des participants sont déjà inscrits</returns>
        public static bool SupprimerActivite(int numActivite)
        {
            bool peutEtreSupprime = false;

            //On vérifie que l'activité peut être supprimée
            SqlCommand reqPeutEtreSupprime = new SqlCommand(
                "SELECT count(*) FROM participer WHERE numActivite = @num",
                Passerelle.connexionBaseLugati);
            reqPeutEtreSupprime.Parameters.AddWithValue("@num", numActivite);

            int nbParticipants = 0;
            try
            {
                Passerelle.connexionBaseLugati.Open();

                nbParticipants = (int)reqPeutEtreSupprime.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            if (nbParticipants == 0)
            {
                peutEtreSupprime = true;

                SqlCommand reqSupprimerActivite = new SqlCommand(
                    "DELETE FROM Activite WHERE numActivite = @num",
                    Passerelle.connexionBaseLugati);
                reqSupprimerActivite.Parameters.AddWithValue("@num", numActivite);

                try
                {
                    Passerelle.connexionBaseLugati.Open();

                    reqSupprimerActivite.ExecuteNonQuery();
                }
                finally
                {
                    Passerelle.connexionBaseLugati.Close();
                }
            }

            return peutEtreSupprime;
        }

        /// <summary>
        /// Modifie une activité dans la base de données
        /// </summary>
        /// <param name="a">Objet de l'activité à modifier</param>
        public static void ModifierActivite(Activite a)
        {
            SqlCommand reqModifierActivite = new SqlCommand(
                "UPDATE Activite " +
                "SET libelle = @libelle, " +
                "    tarif = @tarif, " +
                "    nbPlaces = @nbPlaces, " +
                "    date = @date, " +
                "    heure = @heure " +
                "WHERE numActivite = @numActivite",
                Passerelle.connexionBaseLugati);
            reqModifierActivite.Parameters.AddWithValue("@libelle", a.libelle);
            reqModifierActivite.Parameters.AddWithValue("@tarif", a.tarif);
            reqModifierActivite.Parameters.AddWithValue("@nbPlaces", a.nbPlaces);
            reqModifierActivite.Parameters.AddWithValue("@date", a.date);
            reqModifierActivite.Parameters.AddWithValue("@heure", a.heure);
            reqModifierActivite.Parameters.AddWithValue("@numActivite", a.numActivite);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqModifierActivite.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        #endregion


        #region Participant //////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne toutes les activités
        /// </summary>
        public static List<Participant> GetLesParticipants()
        {
            List<Participant> lesParticipants = new List<Participant>();

            SqlCommand reqLesParticipants = new SqlCommand(
                "SELECT idParticipant, nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue, acompte " +
                "FROM participant",
                Passerelle.connexionBaseLugati);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesParticipants = reqLesParticipants.ExecuteReader();

                if (readerLesParticipants.HasRows)
                {
                    while (readerLesParticipants.Read())
                    {
                        Participant p = new Participant();
                        p.idParticipant = (int)readerLesParticipants[0];
                        p.nom = readerLesParticipants[1].ToString();
                        p.prenom = readerLesParticipants[2].ToString();
                        p.genre = Convert.ToChar(readerLesParticipants[3].ToString());
                        p.adresse = readerLesParticipants[4].ToString();
                        p.ville = readerLesParticipants[5].ToString();
                        p.cp = readerLesParticipants[6].ToString();
                        p.idHebergement = (int)readerLesParticipants[7];
                        p.idLigue = (int)readerLesParticipants[8];
                        p.acompte = Convert.ToSingle(readerLesParticipants[9].ToString());

                        lesParticipants.Add(p);
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesParticipants;
        }

        /// <summary>
        /// Ajoute un participant à la base de données
        /// </summary>
        /// <param name="p">Objet du participant à ajouter</param>
        /// <returns>Identifiant deu participant ajouté</returns>
        public static int AjouterParticipant(Participant p)
        {
            SqlCommand reqAjouterParticipant = new SqlCommand(
                "INSERT INTO Participant (nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue) " +
                "OUTPUT INSERTED.idParticipant " +
                "VALUES (@nom, @prenom, @genre, @adresse, @ville, @cp, @idHebergement, @idLigue)",
                Passerelle.connexionBaseLugati);
            reqAjouterParticipant.Parameters.AddWithValue("@nom", p.nom);
            reqAjouterParticipant.Parameters.AddWithValue("@prenom", p.prenom);
            reqAjouterParticipant.Parameters.AddWithValue("@genre", p.genre);
            reqAjouterParticipant.Parameters.AddWithValue("@adresse", p.adresse);
            reqAjouterParticipant.Parameters.AddWithValue("@ville", p.ville);
            reqAjouterParticipant.Parameters.AddWithValue("@cp", p.cp);
            reqAjouterParticipant.Parameters.AddWithValue("@idHebergement", p.idHebergement);
            reqAjouterParticipant.Parameters.AddWithValue("@idLigue", p.idLigue);

            int id = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();

                id = (int)reqAjouterParticipant.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return id;
        }

        /// <summary>
        /// Supprime un participant de la base de données
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant à supprimer</param>
        /// <returns>false si le participant participe à des sessions ou des activités</returns>
        public static bool SupprimerParticipant(int idParticipant)
        {
            bool peutEtreSupprime = false;

            //On vérifie que le participant peut être supprimée
            SqlCommand reqPeutEtreSupprime = new SqlCommand(
                "SELECT count(*) " +
                "FROM participant p " +
                " JOIN participer p2 on p2.idParticipant = p.idParticipant " +
                " JOIN inscrire i on i i.idParticipant = p.idParticipant " +
                "WHERE idParticipant = @id",
                Passerelle.connexionBaseLugati);
            reqPeutEtreSupprime.Parameters.AddWithValue("@id", idParticipant);

            int nbParticipants = 0;
            try
            {
                Passerelle.connexionBaseLugati.Open();

                nbParticipants = (int)reqPeutEtreSupprime.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            if (nbParticipants == 0)
            {
                peutEtreSupprime = true;

                SqlCommand reqSupprimerParticipant = new SqlCommand(
                    "DELETE FROM participant WHERE idParticipant = @id",
                    Passerelle.connexionBaseLugati);
                reqSupprimerParticipant.Parameters.AddWithValue("@id", idParticipant);

                try
                {
                    Passerelle.connexionBaseLugati.Open();

                    reqSupprimerParticipant.ExecuteNonQuery();
                }
                finally
                {
                    Passerelle.connexionBaseLugati.Close();
                }
            }

            return peutEtreSupprime;
        }

        /// <summary>
        /// Modifie un participant dans la base de données
        /// </summary>
        /// <param name="p">Objet du participant à modifier</param>
        public static void ModifierParticipant(Participant p)
        {
            SqlCommand reqModifierParticipant = new SqlCommand(
                "UPDATE participant " +
                "SET nom = @nom, " +
                "    prenom = @prenom, " +
                "    genre = @genre, " +
                "    idLigue = @idLigue, " +
                "    adresse = @adresse, " +
                "    ville = @ville, " +
                "    cp = @cp, " +
                "    idHebergement = @idHebergement " +
                "WHERE idParticipant = @idParticipant",
                Passerelle.connexionBaseLugati);
            reqModifierParticipant.Parameters.AddWithValue("@nom", p.nom);
            reqModifierParticipant.Parameters.AddWithValue("@prenom", p.prenom);
            reqModifierParticipant.Parameters.AddWithValue("@genre", p.genre);
            reqModifierParticipant.Parameters.AddWithValue("@adresse", p.adresse);
            reqModifierParticipant.Parameters.AddWithValue("@ville", p.ville);
            reqModifierParticipant.Parameters.AddWithValue("@cp", p.cp);
            reqModifierParticipant.Parameters.AddWithValue("@idHebergement", p.idHebergement);
            reqModifierParticipant.Parameters.AddWithValue("@idLigue", p.idLigue);
            reqModifierParticipant.Parameters.AddWithValue("@idParticipant", p.idParticipant);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqModifierParticipant.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        #endregion


        #region Ligue ////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne la liste des ligues
        /// </summary>
        public static List<Ligue> GetLesLigues()
        {
            List<Ligue> lesLigues = new List<Ligue>();

            SqlCommand reqlesLigues = new SqlCommand(
                "SELECT idLigue, nomLigue, adresse, cp, ville " +
                "FROM ligue",
                Passerelle.connexionBaseLugati);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesLigues = reqlesLigues.ExecuteReader();

                if (readerLesLigues.HasRows)
                {
                    while (readerLesLigues.Read())
                    {
                        lesLigues.Add(new Ligue(
                                (int)readerLesLigues[0],
                                readerLesLigues[1].ToString(),
                                readerLesLigues[2].ToString(),
                                readerLesLigues[3].ToString(),
                                readerLesLigues[4].ToString()));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesLigues;
        }

        #endregion


        #region Hebergement //////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne tous les hébergements
        /// </summary>
        public static List<Hebergement> GetLesHebergements()
        {
            List<Hebergement> lesHebergements = new List<Hebergement>();

            SqlCommand reqLesHebergements = new SqlCommand(
                "SELECT idHebergement, nomHebergement, adresse, ville, cp, tel, nbEtoile, prix " +
                "FROM Hebergement",
                Passerelle.connexionBaseLugati);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesHebergements = reqLesHebergements.ExecuteReader();

                if (readerLesHebergements.HasRows)
                {
                    while (readerLesHebergements.Read())
                    {
                        lesHebergements.Add(new Hebergement(
                                (int)readerLesHebergements[0],
                                readerLesHebergements[1].ToString(),
                                readerLesHebergements[2].ToString(),
                                readerLesHebergements[3].ToString(),
                                readerLesHebergements[4].ToString(),
                                readerLesHebergements[5].ToString(),
                                (int)readerLesHebergements[6],
                                (int)readerLesHebergements[7]));
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesHebergements;
        }

        /// <summary>
        /// Ajoute un héberegment à la base de données
        /// </summary>
        /// <param name="h">Objet de l'hébergement à ajouter</param>
        /// <returns>Identifiant de l'hébergement ajouté</returns>
        public static int AjouterHebergement(Hebergement h)
        {
            SqlCommand reqAjouterHebergement = new SqlCommand(
                "INSERT INTO Hebergement (nomHebergement, adresse, ville, cp, tel, nbEtoile, prix) " +
                "OUTPUT INSERTED.idHebergement " +
                "VALUES (@nomHebergement, @adresse, @ville, @cp, @tel, @nbEtoile, @prix)",
                Passerelle.connexionBaseLugati);
            reqAjouterHebergement.Parameters.AddWithValue("@nomHebergement", h.nomHebergement);
            reqAjouterHebergement.Parameters.AddWithValue("@adresse", h.adresse);
            reqAjouterHebergement.Parameters.AddWithValue("@ville", h.ville);
            reqAjouterHebergement.Parameters.AddWithValue("@cp", h.cp);
            reqAjouterHebergement.Parameters.AddWithValue("@tel", h.tel);
            reqAjouterHebergement.Parameters.AddWithValue("@nbEtoile", h.nbEtoile);
            reqAjouterHebergement.Parameters.AddWithValue("@prix", h.prix);

            int id = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();

                id = (int)reqAjouterHebergement.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return id;
        }

        /// <summary>
        /// Supprimer un hébergement de la base de données
        /// </summary>
        /// <param name="idHebergement">Identifiant de l'hébergement à supprimer</param>
        /// <returns>false si des participants sont déjà hébergés</returns>
        public static bool SupprimerHebergement(int idHebergement)
        {
            bool peutEtreSupprime = false;

            //On vérifie que l'hébergement peut être supprimée
            SqlCommand reqPeutEtreSupprime = new SqlCommand(
                "SELECT count(*) FROM participant WHERE idHebergement = @id",
                Passerelle.connexionBaseLugati);
            reqPeutEtreSupprime.Parameters.AddWithValue("@id", idHebergement);

            int nbParticipantsHeberges = 0;
            try
            {
                Passerelle.connexionBaseLugati.Open();

                nbParticipantsHeberges = (int)reqPeutEtreSupprime.ExecuteScalar();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            if(nbParticipantsHeberges == 0)
            {
                peutEtreSupprime = true;

                SqlCommand reqSupprimerHebergement = new SqlCommand(
                    "DELETE FROM Hebergement WHERE idHebergement = @id",
                    Passerelle.connexionBaseLugati);
                reqSupprimerHebergement.Parameters.AddWithValue("@id", idHebergement);

                try
                {
                    Passerelle.connexionBaseLugati.Open();

                    reqSupprimerHebergement.ExecuteNonQuery();
                }
                finally
                {
                    Passerelle.connexionBaseLugati.Close();
                }
            }

            return peutEtreSupprime;
        }

        /// <summary>
        /// Modifie un hébergement dans la base de données
        /// </summary>
        /// <param name="h">Objet de l'hébergement à modifier</param>
        public static void ModifierHebergement(Hebergement h)
        {
            SqlCommand reqModifierHebergement = new SqlCommand(
                "UPDATE Hebergement " +
                "SET nomHebergement = @nomHebergement, " +
                "    adresse = @adresse, " +
                "    ville = @ville, " +
                "    cp = @cp, tel = @tel, " +
                "    nbEtoile = @nbEtoile, " +
                "    prix = @prix " +
                "WHERE idHebergement = @idHebergement",
                Passerelle.connexionBaseLugati);
            reqModifierHebergement.Parameters.AddWithValue("@nomHebergement", h.nomHebergement);
            reqModifierHebergement.Parameters.AddWithValue("@adresse", h.adresse);
            reqModifierHebergement.Parameters.AddWithValue("@ville", h.ville);
            reqModifierHebergement.Parameters.AddWithValue("@cp", h.cp);
            reqModifierHebergement.Parameters.AddWithValue("@tel", h.tel);
            reqModifierHebergement.Parameters.AddWithValue("@nbEtoile", h.nbEtoile);
            reqModifierHebergement.Parameters.AddWithValue("@prix", h.prix);
            reqModifierHebergement.Parameters.AddWithValue("@idHebergement", h.idHebergement);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqModifierHebergement.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }
        #endregion


        #region Participer ///////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne les participants inscrits à une activité
        /// </summary>
        /// <param name="numActivite">Identifiant de l'activité</param>
        public static List<Participant> GetLesParticipations(int numActivite)
        {
            List<Participant> lesParticipants = new List<Participant>();

            SqlCommand reqLesParticipants = new SqlCommand(
                "SELECT p1.idParticipant, nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue " +
                "FROM participant p1 " +
                "  JOIN participer p2 on p2.idParticipant = p1.idParticipant " +
                "WHERE numActivite = @numA",
                Passerelle.connexionBaseLugati);
            reqLesParticipants.Parameters.AddWithValue("@numA", numActivite);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesParticipants = reqLesParticipants.ExecuteReader();

                if (readerLesParticipants.HasRows)
                {
                    while (readerLesParticipants.Read())
                    {
                        Participant p = new Participant();
                        p.idParticipant = (int)readerLesParticipants[0];
                        p.prenom = readerLesParticipants[2].ToString();
                        p.nom = readerLesParticipants[1].ToString();
                        p.genre = Convert.ToChar(readerLesParticipants[3].ToString());
                        p.adresse = readerLesParticipants[4].ToString();
                        p.cp = readerLesParticipants[6].ToString();
                        p.ville = readerLesParticipants[5].ToString();
                        p.idLigue = (int)readerLesParticipants[7];
                        p.idHebergement = (int)readerLesParticipants[8];

                        lesParticipants.Add(p);
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesParticipants;
        }

        /// <summary>
        /// Ajoute une participation d'un participant à une activité
        /// </summary>
        /// <param name="idParticipant">Idnetifiant du participant</param>
        /// <param name="numActivite">Identifiant de l'activité</param>
        public static void AjouterParticipation(int idParticipant, int numActivite)
        {
            SqlCommand reqAjouterParticiper = new SqlCommand(
                "INSERT INTO participer (idParticipant, numActivite) " +
                "VALUES (@idParticipant, @numActivite)",
                Passerelle.connexionBaseLugati);
            reqAjouterParticiper.Parameters.AddWithValue("@idParticipant", idParticipant);
            reqAjouterParticiper.Parameters.AddWithValue("@numActivite", numActivite);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqAjouterParticiper.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        /// <summary>
        /// Supprime une participation d'un participant à une activité
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        /// <param name="numActivite">Identifiant de l'activité</param>
        public static void SupprimerParticipation(int idParticipant, int numActivite)
        {
            SqlCommand reqSupprimerParticiper = new SqlCommand(
                "DELETE FROM participer " +
                "WHERE idParticipant = @id " +
                "AND numActivite = @num",
                Passerelle.connexionBaseLugati);
            reqSupprimerParticiper.Parameters.AddWithValue("@id", idParticipant);
            reqSupprimerParticiper.Parameters.AddWithValue("@num", numActivite);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqSupprimerParticiper.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        #endregion


        #region Inscrire /////////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne les participants inscrits à une session
        /// </summary>
        /// <param name="numSession">Identifiant de la session</param>
        public static List<Participant> GetLesInscriptions(int numSession)
        {
            List<Participant> lesParticipants = new List<Participant>();

            SqlCommand reqLesParticipants = new SqlCommand(
                "SELECT p.idParticipant, nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue " +
                "FROM participant p " +
                "  JOIN inscrire i on i.idParticipant = p.idParticipant " +
                "WHERE numSession = @numS",
                Passerelle.connexionBaseLugati);
            reqLesParticipants.Parameters.AddWithValue("@numS", numSession);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                SqlDataReader readerLesParticipants = reqLesParticipants.ExecuteReader();

                if (readerLesParticipants.HasRows)
                {
                    while (readerLesParticipants.Read())
                    {
                        Participant p = new Participant();
                        p.idParticipant = (int)readerLesParticipants[0];
                        p.prenom = readerLesParticipants[2].ToString();
                        p.nom = readerLesParticipants[1].ToString();
                        p.genre = Convert.ToChar(readerLesParticipants[3].ToString());
                        p.adresse = readerLesParticipants[4].ToString();
                        p.cp = readerLesParticipants[6].ToString();
                        p.ville = readerLesParticipants[5].ToString();
                        p.idLigue = (int)readerLesParticipants[7];
                        p.idHebergement = (int)readerLesParticipants[8];

                        lesParticipants.Add(p);
                    }
                }
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return lesParticipants;
        }

        /// <summary>
        /// Ajoute une inscription d'un participant à une session
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        /// <param name="numSession">Identifiant de la session</param>
        public static void AjouterInscription(int idParticipant, int numSession)
        {
            SqlCommand reqAjouterInscris = new SqlCommand(
                "INSERT INTO Inscrire (idParticipant, numSession) " +
                "VALUES (@idParticipant, @numSession)",
                Passerelle.connexionBaseLugati);
            reqAjouterInscris.Parameters.AddWithValue("@idParticipant", idParticipant);
            reqAjouterInscris.Parameters.AddWithValue("@numSession", numSession);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqAjouterInscris.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        /// <summary>
        /// Supprime une inscription d'un participant à une session
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        /// <param name="numSession">Identifiant de la session</param>
        public static void SupprimerInscription(int idParticipant, int numSession)
        {
            SqlCommand reqSupprimerInscrire = new SqlCommand(
                "DELETE FROM Inscrire " +
                "WHERE idParticipant = @id " +
                "AND numSession = @num",
                Passerelle.connexionBaseLugati);
            reqSupprimerInscrire.Parameters.AddWithValue("@id", idParticipant);
            reqSupprimerInscrire.Parameters.AddWithValue("@num", numSession);

            try
            {
                Passerelle.connexionBaseLugati.Open();

                reqSupprimerInscrire.ExecuteNonQuery();
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }
        }

        #endregion

        
        #region Procédures ///////////////////////////////////////////////////////////////

        /// <summary>
        /// Retourne le montant total demandé à un participant
        /// </summary>
        /// <param name="idParticipant">Identifiant du participant</param>
        public static float GetLeMontantTotal(int idParticipant)
        {
            SqlCommand reqLesMontants = new SqlCommand(
                "MontantTotalCongressiste",
                Passerelle.connexionBaseLugati);
            reqLesMontants.Parameters.AddWithValue("@idP", idParticipant);
            reqLesMontants.CommandType = CommandType.StoredProcedure;

            float montantTot = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();
                montantTot = float.Parse(reqLesMontants.ExecuteScalar().ToString());
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return montantTot;
        }

        /// <summary>
        /// Retourne le nombre de places restantes à une activité
        /// </summary>
        /// <param name="numActivite">Identifiant de l'activité</param>
        public static float GetNbPlaceByActivite(int numActivite)
        {
            SqlCommand reqLesActivites = new SqlCommand(
                "NbPlaceParActivite",
                Passerelle.connexionBaseLugati);
            reqLesActivites.Parameters.AddWithValue("@numA", numActivite);
            reqLesActivites.CommandType = CommandType.StoredProcedure;

            float nbPlaceA = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();
                nbPlaceA = float.Parse(reqLesActivites.ExecuteScalar().ToString());
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return nbPlaceA;
        }

        /// <summary>
        /// Retourne le nombre de places restantes à une session
        /// </summary>
        /// <param name="numSession">Identifiant de la session</param>
        public static float GetNbPlaceBySession(int numSession)
        {
            SqlCommand reqLesSessions = new SqlCommand(
                "NbPlaceParSession",
                Passerelle.connexionBaseLugati);
            reqLesSessions.Parameters.AddWithValue("@numS", numSession);
            reqLesSessions.CommandType = CommandType.StoredProcedure;

            float nbPlaceS = 0;

            try
            {
                Passerelle.connexionBaseLugati.Open();
                nbPlaceS = float.Parse(reqLesSessions.ExecuteScalar().ToString());
            }
            finally
            {
                Passerelle.connexionBaseLugati.Close();
            }

            return nbPlaceS;
        }

        #endregion
    }
}
