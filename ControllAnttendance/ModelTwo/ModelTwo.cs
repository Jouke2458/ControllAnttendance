namespace ControllAnttendance.ModelTwo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    public partial class ModelTwoContext : DbContext
    {
        public ModelTwoContext(): base("name=ModelTwo")
        {
        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Document> Documents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
