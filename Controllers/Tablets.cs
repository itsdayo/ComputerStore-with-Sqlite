using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using static Microsoft.Data.Sqlite.SqliteDataReader;

namespace ComputerStore.Controllers
{
    public class Tablets
    {
        public string type;
        public string name;
        public string description;
        public string brand;
        public string price;
        public Tablets(string name, string description, string brand, string price, string type)
        {
            this.type = type;
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.description = description;
        }

        public static List<Tablets> GetTablets()
        {
            List<Tablets> Inventory = new List<Tablets>();

            var location = System.AppDomain.CurrentDomain.BaseDirectory;
            var filename = "store_product.db";
            var fullpath = System.IO.Path.Combine(location, filename);

            string cs = String.Format("Data Source= {0}", fullpath);
            string stm = "SELECT SQLITE_VERSION()";

            using var con = new SqliteConnection(cs);
            con.Open();

            using var cmd = new SqliteCommand(stm, con);


            cmd.CommandText = "SELECT * FROM products where type='Tablet'";
            SqliteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Inventory.Add(new Tablets(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
            }

            return Inventory;

        }


    }
}
