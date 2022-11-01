using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material_stock
{   public abstract class DataBase
    {
        public abstract void Open();

        public abstract void Close();

        public abstract NpgsqlConnection Connection { get; }
    }
}
