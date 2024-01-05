using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ECommerce.Database
{
    public class SqlBase
    {
        protected SQLiteConnection db;

        public SqlBase(SQLiteConnection db)
        {
            this.db = db;
        }
    }
}
