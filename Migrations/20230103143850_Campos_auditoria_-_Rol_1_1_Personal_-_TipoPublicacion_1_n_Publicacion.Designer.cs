﻿// <auto-generated />
using System;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace wapi.Migrations
{
    [DbContext(typeof(SSDBContext))]
    [Migration("20230103143850_Campos_auditoria_-_Rol_1_1_Personal_-_TipoPublicacion_1_n_Publicacion")]
    partial class Campos_auditoria__Rol_1_1_Personal__TipoPublicacion_1_n_Publicacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdPublicacion")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_publicacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("titulo");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdPublicacion");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("Entidades.Ciudad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdEstado")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_estado");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("ciudades");
                });

            modelBuilder.Entity("Entidades.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdChat")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_chat");

                    b.Property<Guid?>("IdComentario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_comentario");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_usuario");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comentario");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdChat");

                    b.HasIndex("IdComentario");

                    b.HasIndex("IdUsuario");

                    b.ToTable("comentarios");
                });

            modelBuilder.Entity("Entidades.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdPais")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_pais");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdPais");

                    b.ToTable("estados");
                });

            modelBuilder.Entity("Entidades.EstatusPublicacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.ToTable("estatus_publicaciones");
                });

            modelBuilder.Entity("Entidades.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.ToTable("paises");
                });

            modelBuilder.Entity("Entidades.Personal", b =>
                {
                    b.Property<Guid>("IdPublicacion")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_publicacion");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_usuario");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdRol")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_rol");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("IdPublicacion", "IdUsuario");

                    b.HasIndex("IdRol")
                        .IsUnique();

                    b.HasIndex("IdUsuario");

                    b.ToTable("personal");
                });

            modelBuilder.Entity("Entidades.Profesion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.ToTable("profesiones");
                });

            modelBuilder.Entity("Entidades.Publicacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<int>("Gustan")
                        .HasColumnType("int")
                        .HasColumnName("gustan");

                    b.Property<Guid>("IdEstatus")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_estatus");

                    b.Property<Guid>("IdTipoPublicacion")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_tipo_publicacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<int>("NoGustan")
                        .HasColumnType("int")
                        .HasColumnName("no_gustan");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("titulo");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdEstatus");

                    b.HasIndex("IdTipoPublicacion");

                    b.ToTable("publicaciones");
                });

            modelBuilder.Entity("Entidades.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<bool>("Creador")
                        .HasColumnType("bit")
                        .HasColumnName("creador");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Entidades.TipoPublicacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.ToTable("TipoPublicacion");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("apellido");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("segundo_apellido");

                    b.Property<Guid>("CreadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("creado_por");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("direccion");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("email");

                    b.Property<string>("Email2")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("email2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("fecha_creacion");

                    b.Property<Guid>("IdCiudad")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_ciudad");

                    b.Property<Guid?>("IdProfesion")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_profesion");

                    b.Property<int>("MaximoPublicaciones")
                        .HasColumnType("int")
                        .HasColumnName("max_publicaciones");

                    b.Property<Guid>("ModificadoPor")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("modificado_por");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Nombre2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("segundo_nombre");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("perfil");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("telefono");

                    b.Property<string>("Telefono2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("telefono2");

                    b.Property<DateTime>("UltimaModificacion")
                        .HasColumnType("datetime2")
                        .HasColumnName("ultima_modificacion");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudad");

                    b.HasIndex("IdProfesion");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Entidades.Chat", b =>
                {
                    b.HasOne("Entidades.Publicacion", null)
                        .WithMany("Chats")
                        .HasForeignKey("IdPublicacion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Ciudad", b =>
                {
                    b.HasOne("Entidades.Estado", null)
                        .WithMany("Ciudades")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Comentario", b =>
                {
                    b.HasOne("Entidades.Chat", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("IdChat")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Comentario", null)
                        .WithMany("Citas")
                        .HasForeignKey("IdComentario")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Entidades.Usuario", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Estado", b =>
                {
                    b.HasOne("Entidades.Pais", null)
                        .WithMany("Estados")
                        .HasForeignKey("IdPais")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Personal", b =>
                {
                    b.HasOne("Entidades.Publicacion", "Publicacion")
                        .WithMany("PublicacionesLink")
                        .HasForeignKey("IdPublicacion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Rol", "RolLink")
                        .WithOne("PersonalLink")
                        .HasForeignKey("Entidades.Personal", "IdRol")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany("UsuariosLink")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Publicacion");

                    b.Navigation("RolLink");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.Publicacion", b =>
                {
                    b.HasOne("Entidades.EstatusPublicacion", null)
                        .WithMany("Publicaciones")
                        .HasForeignKey("IdEstatus")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.TipoPublicacion", null)
                        .WithMany("PublicacionesLink")
                        .HasForeignKey("IdTipoPublicacion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.HasOne("Entidades.Ciudad", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("IdCiudad")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entidades.Profesion", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("IdProfesion")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Entidades.Chat", b =>
                {
                    b.Navigation("Comentarios");
                });

            modelBuilder.Entity("Entidades.Ciudad", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Entidades.Comentario", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Entidades.Estado", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Entidades.EstatusPublicacion", b =>
                {
                    b.Navigation("Publicaciones");
                });

            modelBuilder.Entity("Entidades.Pais", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Entidades.Profesion", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Entidades.Publicacion", b =>
                {
                    b.Navigation("Chats");

                    b.Navigation("PublicacionesLink");
                });

            modelBuilder.Entity("Entidades.Rol", b =>
                {
                    b.Navigation("PersonalLink")
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.TipoPublicacion", b =>
                {
                    b.Navigation("PublicacionesLink");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("UsuariosLink");
                });
#pragma warning restore 612, 618
        }
    }
}