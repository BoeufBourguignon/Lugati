using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passerelle
{
    public class Hebergement
    {
        public int idHebergement, nbEtoiles, prix;
        public string nomHebergement, adresse, ville, CP, tel;

        public Hebergement(int idHebergement, string nomHebergement, string adresse, string ville, string CP, string tel, int nbEtoiles, int prix)
        {
            this.idHebergement = idHebergement;
            this.nomHebergement = nomHebergement;
            this.adresse = adresse;
            this.ville = ville;
            this.CP = CP;
            this.tel = tel;
            this.nbEtoiles = nbEtoiles;
            this.prix = prix;
        }
    }
}
