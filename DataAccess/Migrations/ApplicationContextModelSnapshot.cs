// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Philosopher's Stone"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Chamber of Secrets"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Prisoner of Azkaban"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Goblet of Fire"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Order of the Phoenix"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Half-Blood Prince"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Rowling",
                            Content = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry.",
                            Cover = "Paper",
                            Genre = "Fantasy",
                            Title = "Harry Potter and Deathly Hallows"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Score = 3
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Score = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            Score = 5
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            Score = 1
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            Score = 4
                        },
                        new
                        {
                            Id = 6,
                            BookId = 6,
                            Score = 3
                        },
                        new
                        {
                            Id = 7,
                            BookId = 7,
                            Score = 2
                        },
                        new
                        {
                            Id = 8,
                            BookId = 1,
                            Score = 3
                        },
                        new
                        {
                            Id = 9,
                            BookId = 2,
                            Score = 1
                        },
                        new
                        {
                            Id = 10,
                            BookId = 3,
                            Score = 4
                        },
                        new
                        {
                            Id = 11,
                            BookId = 4,
                            Score = 4
                        },
                        new
                        {
                            Id = 12,
                            BookId = 5,
                            Score = 4
                        },
                        new
                        {
                            Id = 13,
                            BookId = 6,
                            Score = 5
                        },
                        new
                        {
                            Id = 14,
                            BookId = 7,
                            Score = 5
                        },
                        new
                        {
                            Id = 15,
                            BookId = 1,
                            Score = 5
                        },
                        new
                        {
                            Id = 16,
                            BookId = 2,
                            Score = 3
                        },
                        new
                        {
                            Id = 17,
                            BookId = 3,
                            Score = 2
                        },
                        new
                        {
                            Id = 18,
                            BookId = 4,
                            Score = 3
                        },
                        new
                        {
                            Id = 19,
                            BookId = 5,
                            Score = 4
                        },
                        new
                        {
                            Id = 20,
                            BookId = 6,
                            Score = 3
                        });
                });

            modelBuilder.Entity("Domain.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reviewer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Message = "Good",
                            Reviewer = "Illia"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            Message = "Well",
                            Reviewer = "Vitalik"
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            Message = "Bad",
                            Reviewer = "Denys"
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            Message = "SO-SO",
                            Reviewer = "Dima"
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            Message = "AWESOME",
                            Reviewer = "Mark"
                        },
                        new
                        {
                            Id = 6,
                            BookId = 6,
                            Message = "EXCELLENT",
                            Reviewer = "Oleg"
                        },
                        new
                        {
                            Id = 7,
                            BookId = 7,
                            Message = "BRAVO",
                            Reviewer = "Vika"
                        },
                        new
                        {
                            Id = 8,
                            BookId = 1,
                            Message = "OMG",
                            Reviewer = "Sophia"
                        },
                        new
                        {
                            Id = 9,
                            BookId = 1,
                            Message = "ohhh shitt",
                            Reviewer = "Dasha"
                        },
                        new
                        {
                            Id = 10,
                            BookId = 1,
                            Message = "not bad",
                            Reviewer = "Hermiona"
                        },
                        new
                        {
                            Id = 11,
                            BookId = 1,
                            Message = "Love it",
                            Reviewer = "Ron"
                        },
                        new
                        {
                            Id = 12,
                            BookId = 1,
                            Message = "Amazing",
                            Reviewer = "Hagrid"
                        },
                        new
                        {
                            Id = 13,
                            BookId = 1,
                            Message = "pooorrr",
                            Reviewer = "Snape"
                        },
                        new
                        {
                            Id = 14,
                            BookId = 1,
                            Message = "no recommended this",
                            Reviewer = "Maggongle"
                        },
                        new
                        {
                            Id = 15,
                            BookId = 1,
                            Message = "great",
                            Reviewer = "Volandemort"
                        },
                        new
                        {
                            Id = 16,
                            BookId = 1,
                            Message = "funny",
                            Reviewer = "Harry"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Rating", b =>
                {
                    b.HasOne("Domain.Entities.Book", null)
                        .WithMany("Ratings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Review", b =>
                {
                    b.HasOne("Domain.Entities.Book", null)
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
