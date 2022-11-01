using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material_stock
{
    public class Material
    {
        public Material(int id)
        {
            _id = id;
        }

        public string Name
        {
            get
            {
                return Command<string>("\"nameOfMaterial\"");
            }
        }
        
        public string Image
        {
            get
            {
                return Command<string>("image");
            }
        }
        public float Price
        {
            get
            {
                return Command<float>("price");
            }
        }

        private T Command<T>(string column)
        {
            stock.Connection.Open();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(
                    $"SELECT {column} FROM \"Material\" WHERE \"idMaterial\" = {_id}",
                    stock.Connection);
            object resultAsObject = npgsqlCommand.ExecuteScalar();
            T resultAsT = (T)Convert.ChangeType(resultAsObject, typeof(T));
            stock.Connection.Close();
            return resultAsT;
        }

        DataBase stock = new StockBD();

        private readonly int _id;
    }
}
