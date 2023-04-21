using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityModelFirts
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<puesto> puesto { get; set; }
        public virtual DbSet<sueldo> sueldo { get; set; }
        public virtual DbSet<trabajador> trabajador { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<puesto>()
                .Property(e => e.puesto1)
                .IsUnicode(false);

            modelBuilder.Entity<puesto>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<puesto>()
                .Property(e => e.tareas)
                .IsUnicode(false);

            modelBuilder.Entity<puesto>()
                .HasMany(e => e.pagos)
                .WithRequired(e => e.puesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<trabajador>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<trabajador>()
                .Property(e => e.apellido_pat)
                .IsUnicode(false);

            modelBuilder.Entity<trabajador>()
                .Property(e => e.apellido_mat)
                .IsUnicode(false);

            modelBuilder.Entity<trabajador>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<trabajador>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<trabajador>()
                .HasMany(e => e.pagos)
                .WithRequired(e => e.trabajador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<trabajador>()
                .HasMany(e => e.sueldo)
                .WithRequired(e => e.trabajador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario)
                .IsFixedLength();

            modelBuilder.Entity<usuarios>()
                .Property(e => e.passwd)
                .IsFixedLength();

            modelBuilder.Entity<usuarios>()
                .Property(e => e.estado)
                .IsFixedLength();

            modelBuilder.Entity<usuarios>()
                .Property(e => e.tipo_usuario)
                .IsFixedLength();
        }
    }
}
