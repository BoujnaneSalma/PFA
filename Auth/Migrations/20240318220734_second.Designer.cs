﻿// <auto-generated />
using System;
using Auth.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Auth.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240318220734_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Auth.Models.Avis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.ToTable("Avis");
                });

            modelBuilder.Entity("Auth.Models.Chambres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Disponibilité")
                        .HasColumnType("bit");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Prix")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Chambres");
                });

            modelBuilder.Entity("Auth.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Auth.Models.Endroit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Langitude")
                        .HasColumnType("int");

                    b.Property<int>("Latitude")
                        .HasColumnType("int");

                    b.Property<int>("VilleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VilleId");

                    b.ToTable("Endroits");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Endroit");
                });

            modelBuilder.Entity("Auth.Models.Paiment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePaiment")
                        .HasColumnType("datetime2");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("TypePaiment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Paiments");
                });

            modelBuilder.Entity("Auth.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Auth.Models.Tables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Nbr_Personnes")
                        .HasColumnType("int");

                    b.Property<int>("Numéro")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<bool>("libre")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("Auth.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Complet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Auth.Models.Ville", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villes");
                });

            modelBuilder.Entity("Auth.Models.Hotel", b =>
                {
                    b.HasBaseType("Auth.Models.Endroit");

                    b.Property<int>("NbrCHambre")
                        .HasColumnType("int");

                    b.Property<int>("NbrEtoile")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Hotel");
                });

            modelBuilder.Entity("Auth.Models.Itineraire", b =>
                {
                    b.HasBaseType("Auth.Models.Endroit");

                    b.HasDiscriminator().HasValue("Itineraire");
                });

            modelBuilder.Entity("Auth.Models.LieuTour", b =>
                {
                    b.HasBaseType("Auth.Models.Endroit");

                    b.Property<DateTime>("Horaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("LieuTour");
                });

            modelBuilder.Entity("Auth.Models.Avis", b =>
                {
                    b.HasOne("Auth.Models.Client", "client")
                        .WithMany("Avis")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("Auth.Models.Chambres", b =>
                {
                    b.HasOne("Auth.Models.Hotel", "hotel")
                        .WithMany("Chambres")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auth.Models.Reservation", "reservation")
                        .WithMany("chambres")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hotel");

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("Auth.Models.Endroit", b =>
                {
                    b.HasOne("Auth.Models.Ville", "ville")
                        .WithMany("Endroit")
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ville");
                });

            modelBuilder.Entity("Auth.Models.Paiment", b =>
                {
                    b.HasOne("Auth.Models.Reservation", "reservation")
                        .WithMany("paiments")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("Auth.Models.Reservation", b =>
                {
                    b.HasOne("Auth.Models.Client", "client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");
                });

            modelBuilder.Entity("Auth.Models.Tables", b =>
                {
                    b.HasOne("Auth.Models.Reservation", "Reservation")
                        .WithMany("tables")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Auth.Models.Client", b =>
                {
                    b.Navigation("Avis");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Auth.Models.Reservation", b =>
                {
                    b.Navigation("chambres");

                    b.Navigation("paiments");

                    b.Navigation("tables");
                });

            modelBuilder.Entity("Auth.Models.Ville", b =>
                {
                    b.Navigation("Endroit");
                });

            modelBuilder.Entity("Auth.Models.Hotel", b =>
                {
                    b.Navigation("Chambres");
                });
#pragma warning restore 612, 618
        }
    }
}
