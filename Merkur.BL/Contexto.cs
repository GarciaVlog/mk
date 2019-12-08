using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkur.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Data Source=yourfunnypics.db.4232052.hostedresource.com; Initial Catalog=yourfunnypics; User ID=yourfunnypics; Password='Temp%123';")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MERKUR PAQUERIA");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeIncio());
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<facturas1> Facturas { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Municipio> Municipio { get; set; }




    }
}
