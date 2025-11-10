using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Taller_2_Gestor.Domain.Entities;

namespace Taller_2_Gestor.Infra;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<EstadoEquipo> EstadoEquipos { get; set; }

    public virtual DbSet<EstadoItem> EstadoItems { get; set; }

    public virtual DbSet<EstadoPresupuesto> EstadoPresupuestos { get; set; }

    public virtual DbSet<ItemPresupuesto> ItemPresupuestos { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<OrdenServicio> OrdenServicios { get; set; }

    public virtual DbSet<Presupuesto> Presupuestos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TipoEquipo> TipoEquipos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Tallerdosbase;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("cliente");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Dni).HasColumnName("dni");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => new { e.IdComentario, e.IdPresupuesto });

            entity.ToTable("comentario");

            entity.Property(e => e.IdComentario).HasColumnName("id_comentario");
            entity.Property(e => e.IdPresupuesto).HasColumnName("id_presupuesto");
            entity.Property(e => e.Detalle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");

            entity.HasOne(d => d.IdPresupuestoNavigation).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.IdPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_comentario_presupuesto");

            entity.HasOne(d => d.IdTecnicoNavigation).WithMany(p => p.ComentarioIdTecnicoNavigations)
                .HasForeignKey(d => d.TecnicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_comentario_tecnico");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.IdEquipo);

            entity.ToTable("equipo");

            entity.Property(e => e.IdEquipo).HasColumnName("id_equipo");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_equipo_cliente");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_equipo_estado");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_esquipo_marca");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Equipos)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_equipo_tipo");
        });

        modelBuilder.Entity<EstadoEquipo>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("estado_equipo");

            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasData(
                new EstadoEquipo { IdEstado = 1, Nombre = "Pendiente de revision" },
                new EstadoEquipo { IdEstado = 2, Nombre = "Pendiente de aprobacion" },
                new EstadoEquipo { IdEstado = 3, Nombre = "Pendiente de contacto" },
                new EstadoEquipo { IdEstado = 4, Nombre = "Pendiente de reparacion" },
                new EstadoEquipo { IdEstado = 5, Nombre = "Cliente contactado" },
                new EstadoEquipo { IdEstado = 6, Nombre = "Pospuesto" },
                new EstadoEquipo { IdEstado = 7, Nombre = "Retirado" }
            );
        });
        modelBuilder.Entity<EstadoItem>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("estado_item");

            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasData(
                new EstadoItem { IdEstado = 1, Nombre = "Pendiente" },
                new EstadoItem { IdEstado = 2, Nombre = "Aprobado" },
                new EstadoItem { IdEstado = 3, Nombre = "Rechazado" },
                new EstadoItem { IdEstado = 4, Nombre = "Pospuesto" },
                new EstadoItem { IdEstado = 5, Nombre = "Realizado" }
            );
        });

        modelBuilder.Entity<EstadoPresupuesto>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("estado_presupuesto");

            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasData(
                new EstadoPresupuesto { IdEstado = 1, Nombre = "Pendiente de aprobacion" },
                new EstadoPresupuesto { IdEstado = 2, Nombre = "Aprobado" },
                new EstadoPresupuesto { IdEstado = 3, Nombre = "Rechazado" },
                new EstadoPresupuesto { IdEstado = 4, Nombre = "Realizado" },
                new EstadoPresupuesto { IdEstado = 5, Nombre = "Pospuesto" },
                new EstadoPresupuesto { IdEstado = 6, Nombre = "Consultar Cliente" }
            );
        });

        modelBuilder.Entity<ItemPresupuesto>(entity =>
        {
            entity.HasKey(e => new { e.NFila, e.IdPresupuesto });

            entity.ToTable("item_presupuesto");

            entity.Property(e => e.NFila).HasColumnName("n_fila");
            entity.Property(e => e.IdPresupuesto).HasColumnName("id_presupuesto");
            entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            entity.Property(e => e.IdOrden).HasColumnName("id_orden");
            entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
            entity.Property(e => e.Necesario)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("necesario");
            entity.Property(e => e.Precio).HasColumnName("precio");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.ItemPresupuestos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_item_estado");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.ItemPresupuestos)
                .HasForeignKey(d => d.IdOrden)
                .HasConstraintName("FK_item_orden");

            entity.HasOne(d => d.IdPresupuestoNavigation).WithMany(p => p.ItemPresupuestos)
                .HasForeignKey(d => d.IdPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_item_presupuesto_presupuesto");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ItemPresupuestos)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_item_servicio");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca);

            entity.ToTable("marca");

            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasData(
                new Marca { IdMarca = 1, Nombre = "Samsung" },
                new Marca { IdMarca = 2, Nombre = "Apple" },
                new Marca { IdMarca = 3, Nombre = "Dell" },
                new Marca { IdMarca = 4, Nombre = "HP" },
                new Marca { IdMarca = 5, Nombre = "Lenovo" }
            );
        });

        modelBuilder.Entity<OrdenServicio>(entity =>
        {
            entity.HasKey(e => e.IdPresupuesto);

            entity.ToTable("orden_servicio");

            entity.Property(e => e.IdPresupuesto)
                .ValueGeneratedNever()
                .HasColumnName("id_presupuesto");
            entity.Property(e => e.Fecha).HasColumnName("fecha");

            entity.HasOne(d => d.IdPresupuestoNavigation).WithOne(p => p.OrdenServicio)
                .HasForeignKey<OrdenServicio>(d => d.IdPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orden_ser__id_pr__05D8E0BE");

            entity.HasOne(d => d.IdTecnicoNavigation).WithMany(p => p.OrdenServicioIdTecnicoNavigations)
                .HasForeignKey(d => d.IdTecnico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_orden_servicio_tecnico");
        });

        modelBuilder.Entity<Presupuesto>(entity =>
        {
            entity.HasKey(e => e.IdPresupuesto);

            entity.ToTable("presupuesto");

            entity.Property(e => e.IdPresupuesto).HasColumnName("id_presupuesto");
            entity.Property(e => e.IdAdministrador).HasColumnName("id_administrador");
            entity.Property(e => e.IdEquipo).HasColumnName("id_equipo");
            entity.Property(e => e.IdEstado)
                .HasDefaultValueSql("('1')")
                .HasColumnName("id_estado");
            entity.Property(e => e.IdTecnico).HasColumnName("id_tecnico");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");

            entity.HasOne(d => d.IdAdministradorNavigation).WithMany(p => p.PresupuestoIdAdministradorNavigations)
                .HasForeignKey(d => d.IdAdministrador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presupuesto_administrador");

            entity.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.IdEquipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presupuesto_equipo");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presupuesto_estado");

            entity.HasOne(d => d.IdTecnicoNavigation).WithMany(p => p.PresupuestoIdTecnicoNavigations)
                .HasForeignKey(d => d.IdTecnico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_presupuesto_tecnico");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_rol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_rol");

            entity.HasData(
                new Rol { IdRol = 1, NombreRol = "Administrador" },
                new Rol { IdRol = 3, NombreRol = "Administrador" },
                new Rol { IdRol = 2, NombreRol = "Tecnico" }
            );
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio);

            entity.ToTable("servicio");

            entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre_servicio");
            entity.Property(e => e.Precio).HasColumnName("precio");

            entity.HasData(
                new Servicio { IdServicio = 1, NombreServicio = "Reparacion" , Precio = 1000},
                new Servicio { IdServicio = 2, NombreServicio = "Mantenimiento", Precio = 1000 },
                new Servicio { IdServicio = 3, NombreServicio = "Actualizacion Software", Precio = 1000 },
                new Servicio { IdServicio = 4, NombreServicio = "Diagnostico", Precio = 1000 }
            );
        });

        modelBuilder.Entity<TipoEquipo>(entity =>
        {
            entity.HasKey(e => e.IdTipo);

            entity.ToTable("tipo_equipo");

            entity.Property(e => e.IdTipo).HasColumnName("id_tipo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasData(
                new TipoEquipo { IdTipo = 1, Nombre = "Laptop" },
                new TipoEquipo { IdTipo = 2, Nombre = "Desktop" },
                new TipoEquipo { IdTipo = 3, Nombre = "Tablet" },
                new TipoEquipo { IdTipo = 4, Nombre = "Smartphone" }
            );
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Mail, "UQ_usuario_mail").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Apellido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usuario_rol");


            entity.HasData(
                new Usuario { IdUsuario = 1, Nombre = "m", Apellido = "m", Mail = "m@m.com", Contrasena = "m", Active = true, IdRol = 1 },
                new Usuario { IdUsuario = 2, Nombre = "t", Apellido = "t", Mail = "t@t.com", Contrasena = "t", Active = true, IdRol = 2 },
                new Usuario { IdUsuario = 3, Nombre = "a", Apellido = "a", Mail = "a@a.com", Contrasena = "a", Active = true, IdRol = 3 }
            );
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
