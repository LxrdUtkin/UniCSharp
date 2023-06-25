﻿// <auto-generated />
using System;
using BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Migrations.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20230514122735_DatabaseCreate")]
    partial class DatabaseCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShop.DAL.Entities.Author", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            ID = new Guid("fa93469a-accb-417b-80ff-a016d34351ce"),
                            FirstName = "Myron",
                            LastName = "Mitchell"
                        },
                        new
                        {
                            ID = new Guid("789dcb66-2ae4-48ad-b79f-3dbdcc5342fc"),
                            FirstName = "Edna",
                            LastName = "Kris"
                        },
                        new
                        {
                            ID = new Guid("fac1de15-37e0-4b9e-a306-80a0ca6fd894"),
                            FirstName = "Pearl",
                            LastName = "Bins"
                        },
                        new
                        {
                            ID = new Guid("414923e3-26e5-41ff-8182-c48678786a12"),
                            FirstName = "Shelly",
                            LastName = "Watsica"
                        },
                        new
                        {
                            ID = new Guid("53d84a43-53f4-48e8-b286-f27964668e2a"),
                            FirstName = "Judith",
                            LastName = "Schaefer"
                        },
                        new
                        {
                            ID = new Guid("908b590a-d111-45d0-809d-240d1aad0b09"),
                            FirstName = "Brittany",
                            LastName = "Jacobi"
                        },
                        new
                        {
                            ID = new Guid("e2b2c20d-a498-4f0a-b074-88908b537f1d"),
                            FirstName = "Meredith",
                            LastName = "Cummings"
                        },
                        new
                        {
                            ID = new Guid("26a5f753-7cf7-4ff6-928f-756a4d1e13ef"),
                            FirstName = "Ida",
                            LastName = "Ledner"
                        },
                        new
                        {
                            ID = new Guid("cf9063df-2dad-4fda-83ec-74984b21581d"),
                            FirstName = "Aubrey",
                            LastName = "Morar"
                        },
                        new
                        {
                            ID = new Guid("643e9724-e8ce-4707-a045-740ce7a2c455"),
                            FirstName = "Barbara",
                            LastName = "Kulas"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Copies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("EditionType")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            ID = new Guid("b93613c1-3eeb-4823-a52a-eaefd0261be3"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("fa93469a-accb-417b-80ff-a016d34351ce"),
                            Copies = -1588354750,
                            Description = "Molestiae possimus doloremque rerum assumenda provident harum.\nAspernatur commodi ut eos deserunt quisquam.",
                            EditionType = 2,
                            Price = 0.07789644739903120m,
                            ReleaseDate = new DateTime(2022, 8, 5, 11, 46, 16, 547, DateTimeKind.Local).AddTicks(3185),
                            Title = "qui"
                        },
                        new
                        {
                            ID = new Guid("7848f24a-91d5-471b-8669-83543ea0a761"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("789dcb66-2ae4-48ad-b79f-3dbdcc5342fc"),
                            Copies = -622504344,
                            Description = "Eum iure esse debitis in placeat.\nTotam molestiae veritatis quis et ullam veritatis est.",
                            EditionType = 0,
                            Price = 0.003446702464206640m,
                            ReleaseDate = new DateTime(2023, 1, 24, 6, 30, 52, 79, DateTimeKind.Local).AddTicks(1768),
                            Title = "quam"
                        },
                        new
                        {
                            ID = new Guid("896e1362-f4d5-4f75-a850-7c202cdcb3b3"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("fac1de15-37e0-4b9e-a306-80a0ca6fd894"),
                            Copies = 663353985,
                            Description = "Mollitia nostrum et rerum eos ut odit voluptas debitis repellendus.",
                            EditionType = 0,
                            Price = 0.3039416866461670m,
                            ReleaseDate = new DateTime(2023, 2, 2, 1, 44, 57, 172, DateTimeKind.Local).AddTicks(416),
                            Title = "ad"
                        },
                        new
                        {
                            ID = new Guid("3f388e31-a6e6-4191-b373-77fe692d1858"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("414923e3-26e5-41ff-8182-c48678786a12"),
                            Copies = -1056779523,
                            Description = "Vel excepturi ex suscipit est vel et nihil.\nInventore eos assumenda labore reprehenderit.",
                            EditionType = 2,
                            Price = 0.2985640671768220m,
                            ReleaseDate = new DateTime(2022, 12, 7, 4, 40, 37, 885, DateTimeKind.Local).AddTicks(5442),
                            Title = "reiciendis"
                        },
                        new
                        {
                            ID = new Guid("0e08a9c8-c0a7-4616-b51d-6378172a18f5"),
                            AgeRestriction = 0,
                            AuthorId = new Guid("53d84a43-53f4-48e8-b286-f27964668e2a"),
                            Copies = 1167167827,
                            Description = "Eaque assumenda voluptatem perferendis quisquam voluptatibus omnis voluptas sint repudiandae. Maxime dolor qui qui aliquam voluptatibus iste. Ut sapiente sit nulla. Molestias aut sint in eum tempore. Dolorum autem voluptatem aspernatur quis corrupti quod et. Molestias labore iusto qui sequi ipsam.",
                            EditionType = 2,
                            Price = 0.7580720791695410m,
                            ReleaseDate = new DateTime(2023, 5, 11, 15, 49, 55, 134, DateTimeKind.Local).AddTicks(1890),
                            Title = "quisquam"
                        },
                        new
                        {
                            ID = new Guid("33f0c0dd-5c7b-4222-a566-01b579bbb3bc"),
                            AgeRestriction = 2,
                            AuthorId = new Guid("908b590a-d111-45d0-809d-240d1aad0b09"),
                            Copies = -804918675,
                            Description = "Dolor ea aut.\nQui nihil ut aliquid sapiente.\nEnim non tempore ad.\nModi ex ea autem quia perferendis quisquam voluptate mollitia perferendis.",
                            EditionType = 1,
                            Price = 0.415468878204680m,
                            ReleaseDate = new DateTime(2022, 5, 31, 16, 50, 52, 426, DateTimeKind.Local).AddTicks(7846),
                            Title = "qui"
                        },
                        new
                        {
                            ID = new Guid("2c7d3111-093f-406a-a2cf-6826d22f3a36"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("e2b2c20d-a498-4f0a-b074-88908b537f1d"),
                            Copies = 741321544,
                            Description = "Dolores quo omnis in provident animi.\nEligendi dolores officia quo.\nError natus atque dolorem vel minima ut iste.\nCumque earum illum dolorem nesciunt est optio natus molestias pariatur.\nFugit modi illum.",
                            EditionType = 0,
                            Price = 0.4511424702603020m,
                            ReleaseDate = new DateTime(2022, 8, 17, 3, 51, 36, 275, DateTimeKind.Local).AddTicks(896),
                            Title = "vel"
                        },
                        new
                        {
                            ID = new Guid("4dddf3f8-3f6b-402e-a0d4-4ea205f53fef"),
                            AgeRestriction = 0,
                            AuthorId = new Guid("26a5f753-7cf7-4ff6-928f-756a4d1e13ef"),
                            Copies = -1319858910,
                            Description = "Itaque nihil alias officia sint voluptatem inventore dolorem quo est.",
                            EditionType = 2,
                            Price = 0.3096270185915580m,
                            ReleaseDate = new DateTime(2023, 3, 23, 5, 54, 29, 964, DateTimeKind.Local).AddTicks(8771),
                            Title = "modi"
                        },
                        new
                        {
                            ID = new Guid("338629d5-7c7c-43a1-8e01-e97f90fe2685"),
                            AgeRestriction = 2,
                            AuthorId = new Guid("cf9063df-2dad-4fda-83ec-74984b21581d"),
                            Copies = -1005780169,
                            Description = "Adipisci atque reprehenderit illum repellat iusto et ex. Enim consequatur id dicta. A neque natus recusandae totam. Ut voluptas aliquid ab recusandae qui. Ex sunt maxime aspernatur. Tempora maiores commodi omnis omnis ad ut at quis qui.",
                            EditionType = 1,
                            Price = 0.5614619162661890m,
                            ReleaseDate = new DateTime(2023, 4, 21, 4, 25, 38, 562, DateTimeKind.Local).AddTicks(2329),
                            Title = "aliquid"
                        },
                        new
                        {
                            ID = new Guid("b3d0a67c-d035-4b71-bc17-196559911eb4"),
                            AgeRestriction = 1,
                            AuthorId = new Guid("643e9724-e8ce-4707-a045-740ce7a2c455"),
                            Copies = -397187734,
                            Description = "et",
                            EditionType = 0,
                            Price = 0.7460292643050350m,
                            ReleaseDate = new DateTime(2023, 1, 21, 7, 9, 12, 270, DateTimeKind.Local).AddTicks(1941),
                            Title = "qui"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.BookCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = new Guid("dca11dd7-a0e7-4041-b400-db3ebba99978"),
                            Name = "Small Granite Salad"
                        },
                        new
                        {
                            ID = new Guid("a4ca9d12-89c3-4abd-976f-4ebd7c619f8e"),
                            Name = "Intelligent Fresh Keyboard"
                        },
                        new
                        {
                            ID = new Guid("5c9ae19e-7bba-4410-b973-af7cc1ab7716"),
                            Name = "Awesome Metal Pizza"
                        },
                        new
                        {
                            ID = new Guid("d215a509-8fbf-44d4-94c2-f64fde44a9c3"),
                            Name = "Handcrafted Soft Table"
                        },
                        new
                        {
                            ID = new Guid("7f102223-53a8-4baa-9558-cb4603ff82ea"),
                            Name = "Practical Metal Shoes"
                        },
                        new
                        {
                            ID = new Guid("d909c5a2-b1a8-4dec-8350-2908e697fb49"),
                            Name = "Generic Steel Chair"
                        },
                        new
                        {
                            ID = new Guid("135f754d-cdc7-4577-9f5c-c2e3cc6ddd05"),
                            Name = "Refined Metal Keyboard"
                        },
                        new
                        {
                            ID = new Guid("e926e8ed-0a90-41dd-bad3-ba5dfb8cf755"),
                            Name = "Practical Soft Pants"
                        },
                        new
                        {
                            ID = new Guid("32b456ae-90ac-44fa-b686-645ca794ae8a"),
                            Name = "Licensed Wooden Bike"
                        },
                        new
                        {
                            ID = new Guid("894a4a1c-9b7b-4f4a-be30-7628b272d80d"),
                            Name = "Small Steel Cheese"
                        });
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.HasOne("BookShop.DAL.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.BookCategory", b =>
                {
                    b.HasOne("BookShop.DAL.Entities.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.DAL.Entities.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("BookShop.DAL.Entities.Category", b =>
                {
                    b.Navigation("BookCategories");
                });
#pragma warning restore 612, 618
        }
    }
}