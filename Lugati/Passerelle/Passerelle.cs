using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lugati.dll
{
    public static class Passerelle
    {
        /// <summary>
        /// Chaine de Connexion à la BDD Lugati sur SQL SERVER
        /// </summary>
        private static SqlConnection connexionBaseLugati = new SqlConnection(
            "Data Source=" + Environment.MachineName.ToString() + ";" +
            "Initial Catalog=base_lugati;" +
            "User Id=LugatiApp;" +
            "Password=b4n4n3");

        /// <summary>
        /// Retourne toutes les sessions présentes dans la base de données
        /// </summary>
        /// <returns>Collection de sessions</returns>
        public static List<Session> GetLesSessions()
        {
            List<Session> lesSessions = new List<Session>();

            SqlCommand reqLesSessions =
                new SqlCommand("SELECT numSession, libelle, tarif, nbPlaces, date, heure " +
                                "FROM Session",
                Passerelle.connexionBaseLugati);

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
            else
            {
                throw new Exception("Il n'existe aucune Sessions");
            }

            Passerelle.connexionBaseLugati.Close();

            return lesSessions;
        }

        public static List<Activite> GetLesActivites()
        {
            List<Activite> lesActivites = new List<Activite>();

            SqlCommand reqLesActivites =
                new SqlCommand("SELECT numActivite, libelle, tarif, nbPlaces, date, heure " +
                                "FROM Activite",
                Passerelle.connexionBaseLugati);

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
            else
            {
                throw new Exception("Il n'existe aucune Sessions");
            }

            Passerelle.connexionBaseLugati.Close();

            return lesActivites;
        }

        #region Participant
        /// <summary>
        /// Ajouter un participant
        /// </summary>
        /// <param name="p">Paramètre</param>
        /// <returns></returns>
        public static int AjouterParticipant(Participant p)
        {
            SqlCommand reqAjouterParticipant =
                new SqlCommand("INSERT INTO Participant (nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue) " +
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

        public static void ModifierParticipant(Participant p)
        {
            SqlCommand reqModifierParticipant =
                new SqlCommand("UPDATE Participant SET nom = @nom, prenom = @prenom, genre = @genre, adresse = @adresse, ville = @ville, cp = @cp, idHebergement = @idHebergement, idLigue = @idLigue " +
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

        public static List<Participant> GetLesParticipants()
        {
            List<Participant> lesParticipants = new List<Participant>();

            SqlCommand reqLesParticipants =
                new SqlCommand("SELECT idParticipant, nom, prenom, genre, adresse, ville, cp, idHebergement, idLigue " + 
                                "FROM Participant",
                Passerelle.connexionBaseLugati);

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
            else
            {
                throw new Exception("Il n'existe aucune Sessions");
            }

            Passerelle.connexionBaseLugati.Close();

            return lesParticipants;
        }

        public static void SupprimerParticipant(int idParticipant)
        {
            SqlCommand reqSupprimerParticipant = new SqlCommand(
                "DELETE FROM Participant WHERE idParticipant = @id",
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
        #endregion

        #region Hebergement
        /// <summary>
        /// Retourne tous les Hotels présent dans la base de données
        /// </summary>
        /// <returns>Collection d'Hotels</returns>
        public static List<Hebergement> GetLesHebergements()
        {
            List<Hebergement> lesHebergements = new List<Hebergement>();

            SqlCommand reqLesHebergements =
                new SqlCommand("SELECT idHebergement, nomHebergement, adresse, ville, cp, tel, nbEtoile, prix " +
                                "FROM Hebergement",
                Passerelle.connexionBaseLugati);

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
            else
            {
                throw new Exception("Il n'existe aucun Hebergements");
            }

            Passerelle.connexionBaseLugati.Close();

            return lesHebergements;
        }

        /// <summary>
        /// Ajoute un heberegment à la base de donénes
        /// </summary>
        /// <param name="h">Hebergement à ajouter</param>
        /// <returns>Id de l'hebergement ajouté</returns>
        public static int AjouterHebergement(Hebergement h)
        {
            SqlCommand reqAjouterHebergement =
                new SqlCommand("INSERT INTO Hebergement (nomHebergement, adresse, ville, cp, tel, nbEtoile, prix) " +
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
        /// Supprimer un hébergement
        /// </summary>
        /// <param name="idHebergement">Hebergement à supprimer</param>
        public static void SupprimerHebergement(int idHebergement)
        {
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

        /// <summary>
        /// Modifie un hebergement dans la base de données
        /// </summary>
        /// <param name="h">Hebergement à modifier</param>
        public static void ModifierHebergement(Hebergement h)
        {
            SqlCommand reqModifierHebergement =
                new SqlCommand("UPDATE Hebergement SET nomHebergement = @nomHebergement, adresse = @adresse, ville = @ville, cp = @cp, tel = @tel, nbEtoile = @nbEtoile, prix = @prix " +
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
    }
}
