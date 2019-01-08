using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UPT.Models;

namespace UPT.Data_Access_Layer
{
    public class ContextUniversitate : DbContext
    {
        public DbSet<Curs> Cursuri { get; set; }
        public DbSet<Departament> Departamente { get; set; }
        public DbSet<Inscriere> Inscrieri { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Cabinet> Cabinete { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Curs>()
                .HasMany(c => c.Profesori).WithMany(i => i.Cursuri)
                .Map(t => t.MapLeftKey("IDCurs")
                    .MapRightKey("IDProfesor")
                    .ToTable("ProfesorCurs"));
        }
    }
}