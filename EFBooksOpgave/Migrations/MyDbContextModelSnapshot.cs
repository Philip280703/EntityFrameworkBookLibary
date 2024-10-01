﻿// <auto-generated />
using System;
using EFBooksOpgave.DbAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookLoaner", b =>
                {
                    b.Property<int>("LoanersLoanerId")
                        .HasColumnType("int");

                    b.Property<int>("LoansBookId")
                        .HasColumnType("int");

                    b.HasKey("LoanersLoanerId", "LoansBookId");

                    b.HasIndex("LoansBookId");

                    b.ToTable("BookLoaner");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NextInSeriesId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfPages")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCopies")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("NextInSeriesId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Loaner", b =>
                {
                    b.Property<int>("LoanerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoanerId");

                    b.ToTable("Loaners");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookLoaner", b =>
                {
                    b.HasOne("EFBooksOpgave.Models.Loaner", null)
                        .WithMany()
                        .HasForeignKey("LoanersLoanerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFBooksOpgave.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("LoansBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Book", b =>
                {
                    b.HasOne("EFBooksOpgave.Models.Author", "Author")
                        .WithMany("BooksWritten")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFBooksOpgave.Models.Book", "NextInSeries")
                        .WithMany()
                        .HasForeignKey("NextInSeriesId");

                    b.Navigation("Author");

                    b.Navigation("NextInSeries");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Review", b =>
                {
                    b.HasOne("EFBooksOpgave.Models.Book", "book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Author", b =>
                {
                    b.Navigation("BooksWritten");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
