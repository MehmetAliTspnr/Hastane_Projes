﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
            { SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-8S41M5JH;Initial Catalog=HastaneProjesi;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
