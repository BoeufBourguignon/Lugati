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
            "Data Source=DESKTOP-1QBGM1M;" +
            "Initial Catalog=base_lugati;" +
            "User Id=LugatiApp;" +
            "Password=b4n4n3");
    }
}
