﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleMusicStore.Data;

namespace SimpleMusicStore.Data.Migrations
{
    [DbContext(typeof(SimpleMusicStoreDbContext))]
    partial class SimpleMusicStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleMusicStore.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Artist", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.ArtistFollow", b =>
                {
                    b.Property<int>("ArtistId");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("Date");

                    b.HasKey("ArtistId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ArtistFollows");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DateEdited");

                    b.Property<int>("RecordId");

                    b.Property<string>("Text");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Item", b =>
                {
                    b.Property<int>("RecordId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("RecordId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Label", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.LabelFollow", b =>
                {
                    b.Property<int>("LabelId");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("Date");

                    b.HasKey("LabelId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LabelFollows");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("DeliveryAddressId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Record", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("ArtistId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Format");

                    b.Property<string>("Genre");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<int>("LabelId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("LabelId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("Quantity");

                    b.Property<int>("RecordId");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duration");

                    b.Property<int>("RecordId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("Name");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RecordId");

                    b.Property<string>("Uri")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Wish", b =>
                {
                    b.Property<int>("RecordId");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("Date");

                    b.HasKey("RecordId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Wishes");
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Address", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.ArtistFollow", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Artist", "Artist")
                        .WithMany("Followers")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany("FollowedArtists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Comment", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("Comments")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Item", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("Orders")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.LabelFollow", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Label", "Label")
                        .WithMany("Followers")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany("FollowedLabels")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Order", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Address", "DeliveryAddress")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Record", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Artist", "Artist")
                        .WithMany("Records")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.Label", "Label")
                        .WithMany("Records")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Stock", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("Stocks")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Track", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("Tracklist")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Video", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("Videos")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleMusicStore.Entities.Wish", b =>
                {
                    b.HasOne("SimpleMusicStore.Entities.Record", "Record")
                        .WithMany("WishedBy")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleMusicStore.Entities.User", "User")
                        .WithMany("Wishlist")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
