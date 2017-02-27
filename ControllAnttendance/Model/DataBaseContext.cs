using ControllAnttendance.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllAnttendance
{
    class DataBaseContext: DbContext
    {
        public DataBaseContext() : base("DataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }

        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Document> Documents { get; set; }

    }
}
