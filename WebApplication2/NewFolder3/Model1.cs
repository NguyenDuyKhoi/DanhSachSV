using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.NewFolder3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model17")
        {
        }

        public virtual DbSet<HocLuc> HocLucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
