﻿// <auto-generated />
using EFBooksOpgave.DbAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFBooksOpgave.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241001082145_BooksAddedGenre")]
    partial class BooksAddedGenre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("NumberOfCopies")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

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

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EFBooksOpgave.Models.Author", b =>
                {
                    b.Navigation("BooksWritten");
                });
#pragma warning restore 612, 618
        }
    }
}
