﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MojtabaBookStore.Models;

namespace MojtabaBookStore.Migrations
{
    [DbContext(typeof(BookStoreDb))]
    [Migration("20190523191658_Edit_Provinces")]
    partial class Edit_Provinces
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MojtabaBookStore.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Author_Book", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<int>("AuthorID");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Author_Books");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("File");

                    b.Property<string>("ISBN");

                    b.Property<byte[]>("Image")
                        .HasColumnType("image");

                    b.Property<bool?>("IsDeleted");

                    b.Property<bool?>("IsPublished");

                    b.Property<int>("LanguageID");

                    b.Property<int>("NumOfPages");

                    b.Property<int>("Price");

                    b.Property<DateTime?>("PublishDate");

                    b.Property<int>("PublishYear");

                    b.Property<int>("PublisherID");

                    b.Property<int>("Stock");

                    b.Property<string>("Summary");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<short>("Weight");

                    b.HasKey("BookID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("PublisherID");

                    b.ToTable("BookInfo");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book_Category", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<int>("CategoryID");

                    b.HasKey("BookID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Book_Categories");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book_Translator", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<int>("TranslatorID");

                    b.HasKey("BookID", "TranslatorID");

                    b.HasIndex("TranslatorID");

                    b.ToTable("Book_Translators");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<int?>("ParentCategoryID");

                    b.HasKey("CategoryID");

                    b.HasIndex("ParentCategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "هنر"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "عمومی"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "دانشگاهی"
                        });
                });

            modelBuilder.Entity("MojtabaBookStore.Models.City", b =>
                {
                    b.Property<int>("CityID");

                    b.Property<string>("CityName");

                    b.Property<int?>("ProvinceID");

                    b.HasKey("CityID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CityID1");

                    b.Property<int>("CityID2");

                    b.Property<string>("FirstName")
                        .HasColumnName("FName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Image");

                    b.Property<string>("LastName")
                        .HasColumnName("LName")
                        .HasMaxLength(100);

                    b.Property<string>("Mobile");

                    b.Property<string>("Tell");

                    b.HasKey("CustomerID");

                    b.HasIndex("CityID1");

                    b.HasIndex("CityID2");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Discount", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<DateTime?>("EndDate");

                    b.Property<byte>("Percent");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("BookID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AmountPaid");

                    b.Property<DateTime>("BuyDate");

                    b.Property<string>("CustomerID");

                    b.Property<string>("DispatchNumber");

                    b.Property<int?>("OrderStatusID");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderStatusID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStatusName");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Order_Book", b =>
                {
                    b.Property<int>("BookID");

                    b.Property<string>("OrderID");

                    b.HasKey("BookID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("Order_Books");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Province", b =>
                {
                    b.Property<int>("ProvinceID");

                    b.Property<string>("ProvinceName");

                    b.HasKey("ProvinceID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublisherName");

                    b.HasKey("PublisherID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Translator", b =>
                {
                    b.Property<int>("TranslatorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Family")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("TranslatorID");

                    b.ToTable("Translators");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Author_Book", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Author", "Author")
                        .WithMany("Author_Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.Book", "Book")
                        .WithMany("Author_Books")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book_Category", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Book", "Book")
                        .WithMany("Book_Categories")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.Category", "Category")
                        .WithMany("Book_Categories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Book_Translator", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Book", "Book")
                        .WithMany("Book_Translators")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.Translator", "Translator")
                        .WithMany("Book_Translators")
                        .HasForeignKey("TranslatorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Category", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Category", "category")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryID");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.City", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Province", "Provice")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceID");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Customer", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.City", "city1")
                        .WithMany("Customers1")
                        .HasForeignKey("CityID1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.City", "city2")
                        .WithMany("Customers2")
                        .HasForeignKey("CityID2")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Discount", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Book", "Book")
                        .WithOne("Discount")
                        .HasForeignKey("MojtabaBookStore.Models.Discount", "BookID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Order", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("MojtabaBookStore.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusID");
                });

            modelBuilder.Entity("MojtabaBookStore.Models.Order_Book", b =>
                {
                    b.HasOne("MojtabaBookStore.Models.Book", "Book")
                        .WithMany("Order_Books")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MojtabaBookStore.Models.Order", "Order")
                        .WithMany("Order_Books")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
