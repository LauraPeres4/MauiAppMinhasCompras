using MauiAppMinhasCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteDatabaseHelper _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }

    }
}
