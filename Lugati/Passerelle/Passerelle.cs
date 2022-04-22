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
        private static SqlConnection connexionBaseTravel = new SqlConnection(
            "Data Source=" + Environment.MachineName.ToString() + ";" +
            "Initial Catalog=base_lugati;" +
            "User Id=LugatiApp;" +
            "Password=b4n4n3");

        /// <summary>
        /// Retourne tous les hotels présent dans la base de données
        /// </summary>
        /// <returns>Collection d'hotels</returns>
        public static List<Hebergement> GetLesVoyages()
        {
            List<Voyage> lesVoyages = new List<Voyage>();

            SqlCommand reqLesVoyages =
                new SqlCommand("SELECT num, titre, nbPlace, tarif " +
                                "FROM Voyage",
                ClassePasserelle.connexionBaseTravel);

            ClassePasserelle.connexionBaseTravel.Open();

            SqlDataReader readerLesVoyages = reqLesVoyages.ExecuteReader();

            if (readerLesVoyages.HasRows)
            {
                while (readerLesVoyages.Read())
                {
                    lesVoyages.Add(new Voyage(
                            (int)readerLesVoyages[0],
                            readerLesVoyages[1].ToString(),
                            (int)readerLesVoyages[2],
                            (int)readerLesVoyages[3])
                        );
                }
            }
            else
            {
                throw new Exception("Il n'existe aucun voyage");
            }

            ClassePasserelle.connexionBaseTravel.Close();

            return lesVoyages;
        }
    }
}
