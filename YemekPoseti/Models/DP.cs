using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper; 
using System.Data;
using System.Data.SqlClient;

namespace YemekPoseti.Models
{
    public class DP
    {
        private static string connectionString = @"Server=DESKTOP-5176PJK\SQLEXPRESS;Database=YemekPoseti; 
        Integrated Security=true";

        public static void EXReturn(string procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                baglanti.Execute(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static IEnumerable<T> Returnlist<T>
            (String procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                return baglanti.Query<T>(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}