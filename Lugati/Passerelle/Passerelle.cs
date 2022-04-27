using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passerelle
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
        /// Ajoute un nouveau hotel dans la base de données et retourne le numéro de ce nouveau hotel
        /// </summary>
        /// <param name="nomHebergement">Nom du nouveau Hotel</param>
        /// <param name="adresse">adresse du nouveau Hotel</param>
        /// <param name="ville">ville du nouveau Hotel</param>
        /// <param name="cp">Code Postal du nouveau Hotel</param>
        /// <param name="tel">Numero de Telephone du nouveau Hotel</param>
        /// <param name="nbEtoile">Nombre d'étoile du nouveau Hotel</param>
        /// <param name="prix">Prix du nouveau Hotel</param>
        public static int AjouterHebergement(string nomHebergement, string adresse, string ville, string cp, string tel, int nbEtoile, int prix)
        {
            SqlCommand reqAjouterHebergement =
                new SqlCommand("INSERT INTO Hebergement (nomHebergement, adresse, ville, cp, tel, nbEtoile, prix) " +
                                "OUTPUT INSERTED.idHebergement " +
                                "VALUES (@nomHebergement, @adresse, @ville, @cp, @tel, @nbEtoile, @prix)",
                Passerelle.connexionBaseLugati);
            reqAjouterHebergement.Parameters.AddWithValue("@nomHebergement", nomHebergement);
            reqAjouterHebergement.Parameters.AddWithValue("@adresse", adresse);
            reqAjouterHebergement.Parameters.AddWithValue("@ville", ville);
            reqAjouterHebergement.Parameters.AddWithValue("@cp", cp);
            reqAjouterHebergement.Parameters.AddWithValue("@tel", tel);
            reqAjouterHebergement.Parameters.AddWithValue("@nbEtoile", nbEtoile);
            reqAjouterHebergement.Parameters.AddWithValue("@prix", prix);

            Passerelle.connexionBaseLugati.Open();

            int id = (int)reqAjouterHebergement.ExecuteScalar();

            Passerelle.connexionBaseLugati.Close();

            return id;
        }

        /// <summary>
        /// Retourne l'identifiant du Hebergement correspondant aux valeurs passés en paramètre à partir de la base de données.
        /// On considère que 2 Hebergements identiques ne peuvent pas exister dans la base de données.
        /// </summary>
        /// <param name="nomHebergement">Nom de l'hotel rechercher</param>
        /// <param name="adresse">adresse de l'hotel rechercher</param>
        /// <param name="ville">Ville de l'hotel rechercher</param>
        /// <param name="cp">Code Postal de l'hotel rechercher</param>
        /// <param name="tel">telephone de l'hotel rechercher</param>
        /// <param name="nbEtoile">Nombre d'étoile de l'hotel rechercher</param>
        /// <param name="prix">Prix de l'hotel rechercher</param>
        /// <returns></returns>
        public static int GetIdHebergement(string nomHebergement, string adresse, string ville, string cp, string tel, int nbEtoile, int prix)
        {
            int id = 0;

            SqlCommand reqGetHebergement =
                new SqlCommand("SELECT idHebergement FROM Hebergement " +
                                "WHERE nomHebergement = @nomHebergement " +
                                "AND adresse = @adresse " +
                                "AND ville = @ville " +
                                "AND cp = @cp " +
                                "AND tel = @tel " +
                                "AND nbEtoile = @nbEtoile " +
                                "AND prix = @prix ",
                Passerelle.connexionBaseLugati);
            reqGetHebergement.Parameters.AddWithValue("@nomHebergement", nomHebergement);
            reqGetHebergement.Parameters.AddWithValue("@adresse", adresse);
            reqGetHebergement.Parameters.AddWithValue("@ville", ville);
            reqGetHebergement.Parameters.AddWithValue("@cp", cp);
            reqGetHebergement.Parameters.AddWithValue("@tel", tel);
            reqGetHebergement.Parameters.AddWithValue("@nbEtoile", nbEtoile);
            reqGetHebergement.Parameters.AddWithValue("@prix", prix);

            Passerelle.connexionBaseLugati.Open();

            object retourReq = reqGetHebergement.ExecuteScalar();
            if (retourReq != null)
            {
                id = (int)retourReq;
            }

            Passerelle.connexionBaseLugati.Close();

            return id;
        }
        /// <summary>
        /// Supprime un Hotel dans la Base de donnée.
        /// </summary>
        /// <param name="lesIdHebergements">Liste des IdHerbegement rechercher</param>
        public static void SupprimerLesHebergements(List<int> lesIdHebergements)
        {
            string reqWhereStr = "IN (" + lesIdHebergements[0];
            foreach (int unId in lesIdHebergements)
            {
                reqWhereStr += ", " + unId;
            }
            reqWhereStr += ") ";

            SqlCommand reqSupprimerHebergement = new SqlCommand("DELETE FROM Hebergement WHERE idHebergement " + reqWhereStr, Passerelle.connexionBaseLugati);

            Passerelle.connexionBaseLugati.Open();

            reqSupprimerHebergement.ExecuteNonQuery();

            Passerelle.connexionBaseLugati.Close();
        }
    }
}
