using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MvcApplication1.Models
{
    public class Model1
    {
        public Model1()
        {

        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["MySQLConnectionString"].ConnectionString;
        }

        public DataTable getVal()
        {
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand("get_val", new MySqlConnection(GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dr);
            //ds.Tables.Add(dt);
            return dt;
        }

        public DataTable updateVal()
        {
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand("update_val", new MySqlConnection(GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dr);
            //ds.Tables.Add(dt);
            return dt;
        }
    }
}