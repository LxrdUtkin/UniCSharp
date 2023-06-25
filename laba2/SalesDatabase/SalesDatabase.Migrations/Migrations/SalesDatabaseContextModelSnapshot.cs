﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesDatabase.Data;

#nullable disable

namespace SalesDatabase.Migrations.Migrations
{
    [DbContext(typeof(SalesDatabaseContext))]
    partial class SalesDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Customer", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = new Guid("9646255f-7823-4cc8-8de9-c754f15b8317"),
                            CreditCardNumber = "5440-0402-5440-6120",
                            Email = "Tonya31@gmail.com",
                            Name = "Tonya"
                        },
                        new
                        {
                            ID = new Guid("b934a5b7-ab63-4137-895d-52ab7bddafaa"),
                            CreditCardNumber = "3529-4022-7927-3712",
                            Email = "Wendell.Wunsch3@yahoo.com",
                            Name = "Wendell"
                        },
                        new
                        {
                            ID = new Guid("cfbefd00-1520-46a9-868f-df3829eb8a8e"),
                            CreditCardNumber = "3577-5580-9093-5747",
                            Email = "Tabitha24@hotmail.com",
                            Name = "Tabitha"
                        },
                        new
                        {
                            ID = new Guid("ec584c02-397c-4a19-8b6e-2745d53ac00f"),
                            CreditCardNumber = "6767-6797-8984-4678",
                            Email = "Cory60@yahoo.com",
                            Name = "Cory"
                        },
                        new
                        {
                            ID = new Guid("f83b725a-3009-4226-a26f-8d20feaa2e54"),
                            CreditCardNumber = "6767-9727-6275-5858",
                            Email = "Melba.Nienow@yahoo.com",
                            Name = "Melba"
                        },
                        new
                        {
                            ID = new Guid("c8e1f825-369f-44f7-a1c5-b0b96d1b7acb"),
                            CreditCardNumber = "3577-8686-3904-0937",
                            Email = "Arnold_Swaniawski75@hotmail.com",
                            Name = "Arnold"
                        },
                        new
                        {
                            ID = new Guid("f77947a7-abb1-4e9b-aec1-14ddf1012db7"),
                            CreditCardNumber = "3016-803185-9795",
                            Email = "Kristy22@gmail.com",
                            Name = "Kristy"
                        },
                        new
                        {
                            ID = new Guid("c6ff3481-b35a-4ff0-ac92-a6d413ac4738"),
                            CreditCardNumber = "5401-4940-9840-4998",
                            Email = "Eduardo.Muller@hotmail.com",
                            Name = "Eduardo"
                        },
                        new
                        {
                            ID = new Guid("243eeeeb-3e6f-41aa-bef9-2cd38f804e97"),
                            CreditCardNumber = "6378-2684-1986-2499",
                            Email = "Terrell.Boyle@gmail.com",
                            Name = "Terrell"
                        },
                        new
                        {
                            ID = new Guid("bcc6f031-2b29-4825-8ca6-c724de2d9ad8"),
                            CreditCardNumber = "3050-322429-4238",
                            Email = "Bobbie.Denesik16@yahoo.com",
                            Name = "Bobbie"
                        });
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasDefaultValue("No description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = new Guid("48362c85-cfd6-45a3-8799-0022cc8c0c8f"),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Incredible Soft Mouse",
                            Price = 2000m,
                            Quantity = 2
                        },
                        new
                        {
                            ID = new Guid("bb19a7da-76f2-4387-abd1-afb4882b1297"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Handmade Soft Towels",
                            Price = 1000m,
                            Quantity = 5
                        },
                        new
                        {
                            ID = new Guid("9263de2e-d9ea-4970-a997-da58c98e7090"),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Incredible Plastic Shoes",
                            Price = 2000m,
                            Quantity = 1
                        },
                        new
                        {
                            ID = new Guid("613c9453-da67-485a-bd4c-3bc825de5499"),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Handmade Plastic Pants",
                            Price = 3000m,
                            Quantity = 4
                        },
                        new
                        {
                            ID = new Guid("86a7df10-1edc-4dbe-ae2d-b73e12497049"),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Tasty Wooden Computer",
                            Price = 3000m,
                            Quantity = 5
                        },
                        new
                        {
                            ID = new Guid("c04d7b3d-4b65-40f5-953b-71bab5ba92b1"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Licensed Frozen Hat",
                            Price = 1000m,
                            Quantity = 1
                        },
                        new
                        {
                            ID = new Guid("6808d9c4-b736-40f3-a472-e4f8f52b135e"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Licensed Plastic Hat",
                            Price = 1000m,
                            Quantity = 3
                        },
                        new
                        {
                            ID = new Guid("f6659400-4b2d-4b09-83b5-52e0156896bf"),
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Handcrafted Soft Car",
                            Price = 2000m,
                            Quantity = 3
                        },
                        new
                        {
                            ID = new Guid("ba904973-4559-424c-9624-ccf027cfaab3"),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Gorgeous Granite Cheese",
                            Price = 1000m,
                            Quantity = 5
                        },
                        new
                        {
                            ID = new Guid("283117dc-e030-49ab-8b1c-be00ebbfbb5a"),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Licensed Wooden Shirt",
                            Price = 3000m,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Sale", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            ID = new Guid("38412591-2341-49b8-bcd1-748b61a75522"),
                            CustomerId = new Guid("9646255f-7823-4cc8-8de9-c754f15b8317"),
                            Date = new DateTime(2024, 4, 4, 11, 54, 22, 625, DateTimeKind.Local).AddTicks(2792),
                            ProductId = new Guid("48362c85-cfd6-45a3-8799-0022cc8c0c8f"),
                            StoreId = new Guid("cdcfaac2-caf4-48da-8d43-3124295da747")
                        },
                        new
                        {
                            ID = new Guid("60cb6cc6-4dc0-4fc9-bb7c-9fc867c8e9b5"),
                            CustomerId = new Guid("b934a5b7-ab63-4137-895d-52ab7bddafaa"),
                            Date = new DateTime(2023, 12, 14, 15, 52, 52, 260, DateTimeKind.Local).AddTicks(6711),
                            ProductId = new Guid("bb19a7da-76f2-4387-abd1-afb4882b1297"),
                            StoreId = new Guid("25f7c7ae-2e49-4a2d-822b-83192f0c7fc6")
                        },
                        new
                        {
                            ID = new Guid("99c61b0d-2908-45b3-94f5-10c4791cebd5"),
                            CustomerId = new Guid("cfbefd00-1520-46a9-868f-df3829eb8a8e"),
                            Date = new DateTime(2023, 9, 5, 5, 13, 9, 146, DateTimeKind.Local).AddTicks(8167),
                            ProductId = new Guid("9263de2e-d9ea-4970-a997-da58c98e7090"),
                            StoreId = new Guid("cd7cb69d-c612-41d7-b087-7d769c6ca332")
                        },
                        new
                        {
                            ID = new Guid("4efa33b2-ac5d-4351-815d-9f77e40ce887"),
                            CustomerId = new Guid("ec584c02-397c-4a19-8b6e-2745d53ac00f"),
                            Date = new DateTime(2024, 2, 11, 0, 20, 21, 60, DateTimeKind.Local).AddTicks(6452),
                            ProductId = new Guid("613c9453-da67-485a-bd4c-3bc825de5499"),
                            StoreId = new Guid("85d95378-116b-4710-be4c-78ed5474d66c")
                        },
                        new
                        {
                            ID = new Guid("5d528fa3-cafb-457d-8908-c7c83be8e167"),
                            CustomerId = new Guid("f83b725a-3009-4226-a26f-8d20feaa2e54"),
                            Date = new DateTime(2023, 7, 24, 2, 4, 3, 359, DateTimeKind.Local).AddTicks(1926),
                            ProductId = new Guid("86a7df10-1edc-4dbe-ae2d-b73e12497049"),
                            StoreId = new Guid("012a5b97-435e-47cb-80e2-2dd85f5f6547")
                        },
                        new
                        {
                            ID = new Guid("8659afec-7d52-4e74-ad37-6176bda3aa6e"),
                            CustomerId = new Guid("c8e1f825-369f-44f7-a1c5-b0b96d1b7acb"),
                            Date = new DateTime(2023, 8, 27, 1, 41, 46, 136, DateTimeKind.Local).AddTicks(8170),
                            ProductId = new Guid("c04d7b3d-4b65-40f5-953b-71bab5ba92b1"),
                            StoreId = new Guid("31035ac9-39d8-449d-a39c-72e3adf7bc22")
                        },
                        new
                        {
                            ID = new Guid("186562f1-d8be-4d00-91fd-5c8328716a6b"),
                            CustomerId = new Guid("f77947a7-abb1-4e9b-aec1-14ddf1012db7"),
                            Date = new DateTime(2024, 4, 21, 10, 7, 59, 693, DateTimeKind.Local).AddTicks(6358),
                            ProductId = new Guid("6808d9c4-b736-40f3-a472-e4f8f52b135e"),
                            StoreId = new Guid("ec894c3b-959a-4d9b-a26e-a5b4cb38d9d1")
                        },
                        new
                        {
                            ID = new Guid("b29e007e-d71a-4bb9-8d33-997c001658c9"),
                            CustomerId = new Guid("c6ff3481-b35a-4ff0-ac92-a6d413ac4738"),
                            Date = new DateTime(2024, 2, 7, 8, 42, 43, 733, DateTimeKind.Local).AddTicks(7538),
                            ProductId = new Guid("f6659400-4b2d-4b09-83b5-52e0156896bf"),
                            StoreId = new Guid("d4567875-d273-4f3e-a9e3-c0041ff060be")
                        },
                        new
                        {
                            ID = new Guid("86abf4ba-8159-4d52-9c6f-6fbe74283419"),
                            CustomerId = new Guid("243eeeeb-3e6f-41aa-bef9-2cd38f804e97"),
                            Date = new DateTime(2023, 11, 11, 22, 32, 15, 905, DateTimeKind.Local).AddTicks(3414),
                            ProductId = new Guid("ba904973-4559-424c-9624-ccf027cfaab3"),
                            StoreId = new Guid("cda8b592-5eef-41f2-b021-1277bda89ae4")
                        },
                        new
                        {
                            ID = new Guid("c2f55458-62b8-44cd-8355-089179434e13"),
                            CustomerId = new Guid("bcc6f031-2b29-4825-8ca6-c724de2d9ad8"),
                            Date = new DateTime(2024, 2, 17, 7, 2, 53, 393, DateTimeKind.Local).AddTicks(9477),
                            ProductId = new Guid("283117dc-e030-49ab-8b1c-be00ebbfbb5a"),
                            StoreId = new Guid("8564f4d2-e570-4f52-bd22-c24f7c06bdeb")
                        });
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Store", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ID");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            ID = new Guid("cdcfaac2-caf4-48da-8d43-3124295da747"),
                            Name = "Keebler, Weimann and Huels"
                        },
                        new
                        {
                            ID = new Guid("25f7c7ae-2e49-4a2d-822b-83192f0c7fc6"),
                            Name = "Brakus, Breitenberg and Blick"
                        },
                        new
                        {
                            ID = new Guid("cd7cb69d-c612-41d7-b087-7d769c6ca332"),
                            Name = "Schneider Inc"
                        },
                        new
                        {
                            ID = new Guid("85d95378-116b-4710-be4c-78ed5474d66c"),
                            Name = "Littel LLC"
                        },
                        new
                        {
                            ID = new Guid("012a5b97-435e-47cb-80e2-2dd85f5f6547"),
                            Name = "Farrell, Zulauf and Medhurst"
                        },
                        new
                        {
                            ID = new Guid("31035ac9-39d8-449d-a39c-72e3adf7bc22"),
                            Name = "White LLC"
                        },
                        new
                        {
                            ID = new Guid("ec894c3b-959a-4d9b-a26e-a5b4cb38d9d1"),
                            Name = "Johns LLC"
                        },
                        new
                        {
                            ID = new Guid("d4567875-d273-4f3e-a9e3-c0041ff060be"),
                            Name = "Feeney - Champlin"
                        },
                        new
                        {
                            ID = new Guid("cda8b592-5eef-41f2-b021-1277bda89ae4"),
                            Name = "Maggio, Kirlin and Vandervort"
                        },
                        new
                        {
                            ID = new Guid("8564f4d2-e570-4f52-bd22-c24f7c06bdeb"),
                            Name = "Herzog - Rodriguez"
                        });
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Sale", b =>
                {
                    b.HasOne("SalesDatabase.DAL.Entities.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDatabase.DAL.Entities.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SalesDatabase.DAL.Entities.Store", "Store")
                        .WithMany("Sales")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Product", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("SalesDatabase.DAL.Entities.Store", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}