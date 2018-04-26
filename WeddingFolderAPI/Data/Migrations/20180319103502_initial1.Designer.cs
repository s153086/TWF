﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WeddingFolderAPI.Data;

namespace WeddingFolderAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180319103502_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Budget", b =>
                {
                    b.Property<int>("BudgetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MaxCost");

                    b.HasKey("BudgetId");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.BudgetItem", b =>
                {
                    b.Property<int>("BudgetItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BudgetId");

                    b.Property<string>("ItemName");

                    b.Property<int>("Price");

                    b.HasKey("BudgetItemId");

                    b.HasIndex("BudgetId");

                    b.ToTable("BudgetItem");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Couple", b =>
                {
                    b.Property<int>("CoupleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoupleName");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("CoupleId");

                    b.ToTable("Couple");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GuestListId");

                    b.Property<string>("Name");

                    b.Property<int>("TableNumber");

                    b.HasKey("GuestId");

                    b.HasIndex("GuestListId");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.GuestList", b =>
                {
                    b.Property<int>("GuestListId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoupleId");

                    b.HasKey("GuestListId");

                    b.ToTable("GuestList");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateBooked");

                    b.Property<string>("LocationName");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.PlanningFolder", b =>
                {
                    b.Property<int>("PlanningFolderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BudgetId");

                    b.Property<int?>("CoupleId");

                    b.Property<string>("FolderName");

                    b.Property<int?>("GuestListId");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Purpose");

                    b.Property<int?>("SeatingPlanId");

                    b.Property<int?>("ToDoListId");

                    b.Property<int?>("WishlistId");

                    b.HasKey("PlanningFolderId");

                    b.HasIndex("BudgetId");

                    b.HasIndex("CoupleId");

                    b.HasIndex("GuestListId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SeatingPlanId");

                    b.HasIndex("ToDoListId");

                    b.HasIndex("WishlistId");

                    b.ToTable("PlanningFolder");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.SeatingPlan", b =>
                {
                    b.Property<int>("SeatingPlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CoupleId");

                    b.Property<int?>("GuestListId");

                    b.HasKey("SeatingPlanId");

                    b.HasIndex("GuestListId");

                    b.ToTable("SeatingPlan");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.ToDoItem", b =>
                {
                    b.Property<int>("ToDoItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Priority");

                    b.Property<int?>("ResponsibleGuestId");

                    b.Property<string>("Task");

                    b.Property<int?>("ToDoListId");

                    b.HasKey("ToDoItemId");

                    b.HasIndex("ResponsibleGuestId");

                    b.HasIndex("ToDoListId");

                    b.ToTable("ToDoItem");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.ToDoList", b =>
                {
                    b.Property<int>("ToDoListId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ToDoListId");

                    b.ToTable("ToDoList");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Category");

                    b.Property<string>("Name");

                    b.Property<int?>("PlanningFolderId");

                    b.Property<int>("Price");

                    b.HasKey("VendorId");

                    b.HasIndex("PlanningFolderId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Wish", b =>
                {
                    b.Property<int>("WishId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MustHaveFactor");

                    b.Property<int>("Price");

                    b.Property<string>("WishTitle");

                    b.Property<int?>("WishlistId");

                    b.HasKey("WishId");

                    b.HasIndex("WishlistId");

                    b.ToTable("Wish");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Wishlist", b =>
                {
                    b.Property<int>("WishlistId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("WishlistId");

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WeddingFolderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.BudgetItem", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.Budget")
                        .WithMany("Items")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Guest", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.GuestList")
                        .WithMany("Guests")
                        .HasForeignKey("GuestListId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.PlanningFolder", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.Budget", "Budget")
                        .WithMany()
                        .HasForeignKey("BudgetId");

                    b.HasOne("WeddingFolderAPI.Models.Couple")
                        .WithMany("Folders")
                        .HasForeignKey("CoupleId");

                    b.HasOne("WeddingFolderAPI.Models.GuestList", "GuestList")
                        .WithMany()
                        .HasForeignKey("GuestListId");

                    b.HasOne("WeddingFolderAPI.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("WeddingFolderAPI.Models.SeatingPlan", "SeatingPlan")
                        .WithMany()
                        .HasForeignKey("SeatingPlanId");

                    b.HasOne("WeddingFolderAPI.Models.ToDoList", "ToDoList")
                        .WithMany()
                        .HasForeignKey("ToDoListId");

                    b.HasOne("WeddingFolderAPI.Models.Wishlist", "WishList")
                        .WithMany()
                        .HasForeignKey("WishlistId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.SeatingPlan", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.GuestList", "GuestList")
                        .WithMany()
                        .HasForeignKey("GuestListId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.ToDoItem", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.Guest", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleGuestId");

                    b.HasOne("WeddingFolderAPI.Models.ToDoList")
                        .WithMany("Items")
                        .HasForeignKey("ToDoListId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Vendor", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.PlanningFolder")
                        .WithMany("Vendors")
                        .HasForeignKey("PlanningFolderId");
                });

            modelBuilder.Entity("WeddingFolderAPI.Models.Wish", b =>
                {
                    b.HasOne("WeddingFolderAPI.Models.Wishlist")
                        .WithMany("Wishes")
                        .HasForeignKey("WishlistId");
                });
#pragma warning restore 612, 618
        }
    }
}
