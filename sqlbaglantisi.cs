﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4FSMIR7\\SQLEXPRESS;Initial Catalog=\"Hastane Proje\";Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
