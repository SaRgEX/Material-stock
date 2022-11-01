using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Material_stock
{
    public sealed class StockBD : DataBase
    {
        public StockBD()
        {
            Connection = new NpgsqlConnection(
                $"Server=10.14.206.27;" +
                $"Port=5432;" +
                $"User ID=student;" +
                $"Password=1234;" +
                $"DataBase=Stock");
        }

        public override void Open()
        {
            Connection.Open();
        }

        public override void Close()
        {
            Connection.Close();
        }

        public override NpgsqlConnection Connection { get; }
    }
}
