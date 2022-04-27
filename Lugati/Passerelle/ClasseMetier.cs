using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passerelle
{
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
}
