﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yado_backend.Data;

#nullable disable

namespace yado_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("yado_backend.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("LogoImg")
                        .IsRequired()
                        .HasColumnType("varbinary(8000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("yado_backend.Models.Country", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Code");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("yado_backend.Models.Favorite", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasMaxLength(40)
                        .HasColumnType("char(40)");

                    b.Property<Guid>("HotelId")
                        .HasMaxLength(255)
                        .HasColumnType("char(255)");

                    b.HasKey("UserId", "HotelId");

                    b.HasIndex("HotelId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("yado_backend.Models.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NumVisited")
                        .HasColumnType("int");

                    b.Property<int>("PopulationId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PopulationId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("yado_backend.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("yado_backend.Models.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("yado_backend.Models.Parameter", b =>
                {
                    b.Property<Guid>("HotelId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("AeroportSchuttle")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AirConditioning")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Balcony")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Bath")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("BicycleRental")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("BlatScreenTv")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("BreakfastDinnerIncluded")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("BreakfastIncluded")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("DoubleBed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EmergencyCordBathroom")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ExtraLargeDoubleBed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FacilitesDisabledGuest")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FamilyRooms")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FitnessCentre")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FreeCancellation")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("GolfCourse")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HigherLevelToilet")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Kitchen")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LaptopFriendlyWorkspace")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LargeDoubleBed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LowerBathroomSink")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Massage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("NonSmokingRooms")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Parking")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Patio")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PetsAllowed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PrivateBathroom")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PrivatePool")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ReceptionAlwaysOpen")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Restaurant")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("RoomService")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SeaView")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SelfCatering")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Solarium")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Soundproofing")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SpaWellnessCentre")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("SwimmingPool")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Terrace")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ToiletGrabRails")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("TwinBeds")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("VeryGoodWifi")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("ViewHotel")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("VisualAidsBraille")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("VisualAidsTactileSigns")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("WashingMachine")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("WheelchairAccessible")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("HotelId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("yado_backend.Models.Population", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryCode");

                    b.ToTable("Populations");
                });

            modelBuilder.Entity("yado_backend.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("char(36)");

                    b.Property<string>("NegativeComment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PositiveComment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<float>("Qualification")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("yado_backend.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("yado_backend.Models.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("char(36)");

                    b.Property<float>("NightlyPrice")
                        .HasColumnType("float");

                    b.Property<string>("OriginUrl")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("varchar(700)");

                    b.Property<string>("TypeRomm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("HotelId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("yado_backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("ImageProfile")
                        .HasColumnType("varbinary(8000)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("yado_backend.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique();

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("yado_backend.Models.UserRoleRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ApprovedByUserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("LastStatusUpdate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("RequestedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedByUserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleRequests");
                });

            modelBuilder.Entity("yado_backend.Models.Favorite", b =>
                {
                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithMany("Favorites")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("yado_backend.Models.Hotel", b =>
                {
                    b.HasOne("yado_backend.Models.Population", "Population")
                        .WithMany("Hotels")
                        .HasForeignKey("PopulationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Population");
                });

            modelBuilder.Entity("yado_backend.Models.Image", b =>
                {
                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithMany("Images")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("yado_backend.Models.Owner", b =>
                {
                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithMany("Owners")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.User", "User")
                        .WithMany("OwnedHotels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("yado_backend.Models.Parameter", b =>
                {
                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithOne("Parameter")
                        .HasForeignKey("yado_backend.Models.Parameter", "HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("yado_backend.Models.Population", b =>
                {
                    b.HasOne("yado_backend.Models.Country", "Country")
                        .WithMany("Populations")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("yado_backend.Models.Review", b =>
                {
                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithMany("Reviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("yado_backend.Models.Site", b =>
                {
                    b.HasOne("yado_backend.Models.Company", "Company")
                        .WithMany("Sites")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.Hotel", "Hotel")
                        .WithMany("Sites")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("yado_backend.Models.UserRole", b =>
                {
                    b.HasOne("yado_backend.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("yado_backend.Models.UserRoleRequest", b =>
                {
                    b.HasOne("yado_backend.Models.User", "ApprovedByUser")
                        .WithMany()
                        .HasForeignKey("ApprovedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("yado_backend.Models.Role", "RequestedRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("yado_backend.Models.User", "User")
                        .WithMany("UserRoleRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovedByUser");

                    b.Navigation("RequestedRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("yado_backend.Models.Company", b =>
                {
                    b.Navigation("Sites");
                });

            modelBuilder.Entity("yado_backend.Models.Country", b =>
                {
                    b.Navigation("Populations");
                });

            modelBuilder.Entity("yado_backend.Models.Hotel", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Images");

                    b.Navigation("Owners");

                    b.Navigation("Parameter")
                        .IsRequired();

                    b.Navigation("Reviews");

                    b.Navigation("Sites");
                });

            modelBuilder.Entity("yado_backend.Models.Population", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("yado_backend.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("yado_backend.Models.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("OwnedHotels");

                    b.Navigation("Reviews");

                    b.Navigation("UserRoleRequests");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
