using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NewReviewWebsite.Data;

namespace NewReviewWebsite.Migrations
{
    [DbContext(typeof(ReviewContext))]
    partial class ReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewReviewWebsite.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlbumName");

                    b.Property<int>("ArtistID");

                    b.Property<int>("GenreID");

                    b.Property<string>("Label");

                    b.Property<string>("Length");

                    b.Property<int>("Rating");

                    b.Property<string>("ReleaseDate");

                    b.Property<int>("ReleaseYear");

                    b.Property<string>("Review");

                    b.HasKey("AlbumID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("GenreID");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("NewReviewWebsite.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumID");

                    b.Property<string>("ArtistName");

                    b.Property<int?>("GenreID");

                    b.HasKey("ArtistID");

                    b.HasIndex("GenreID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("NewReviewWebsite.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreName");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("NewReviewWebsite.Models.Album", b =>
                {
                    b.HasOne("NewReviewWebsite.Models.Artist", "Artists")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NewReviewWebsite.Models.Genre", "Genres")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewReviewWebsite.Models.Artist", b =>
                {
                    b.HasOne("NewReviewWebsite.Models.Genre")
                        .WithMany("Artists")
                        .HasForeignKey("GenreID");
                });
        }
    }
}
