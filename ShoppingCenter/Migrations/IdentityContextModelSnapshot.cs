﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCenter.Areas.Identity.Data;

#nullable disable

namespace ShoppingCenter.Migrations
{
    [DbContext(typeof(IdentityContext))]
    partial class IdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "329a0dd7-9a58-439c-b7d6-799dcecdeb7e",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "0e7305c7-20b5-46c3-9244-b27f2b970573",
                            Name = "ClothesShopAdmin",
                            NormalizedName = "ClothesShopADMIN"
                        },
                        new
                        {
                            Id = "42685d7c-30ad-433b-ac5f-5e4e4869fea4",
                            Name = "ToysShopAdmin",
                            NormalizedName = "ToysShopADMIN"
                        },
                        new
                        {
                            Id = "b2a29728-1838-4086-a898-97ccbc121ab9",
                            Name = "FoodShopAdmin",
                            NormalizedName = "FoodShopADMIN"
                        },
                        new
                        {
                            Id = "c78d2fe5-c43e-40c0-bb8b-e77e51efb203",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ShoppingCenter.Models.CustomerShoppingCart", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId1");

                    b.ToTable("CustomersShoppingCarts");
                });

            modelBuilder.Entity("ShoppingCenter.Models.CustomerShoppingCartItem", b =>
                {
                    b.Property<Guid>("CustomerShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerShoppingCartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerShoppingCartItemId");

                    b.HasIndex("CustomerShoppingCartId");

                    b.HasIndex("ItemId");

                    b.ToTable("CustomerShoppingCartItems");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Item", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailabilityItem")
                        .HasColumnType("int");

                    b.Property<string>("ColorItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SizeItem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemCategory", b =>
                {
                    b.Property<Guid>("ItemCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemCategoryId");

                    b.HasIndex("ItemId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ItemCategoryId = new Guid("5933ebf7-f7ce-46c1-9a34-c3587f26a8d6"),
                            ItemCategoryName = "T-Shirt"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("10ad2415-cf83-4f9d-8acc-44455bb8cb60"),
                            ItemCategoryName = "Trousers"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("b0abc8fd-3430-4e82-80d8-4762755942c9"),
                            ItemCategoryName = "Shoes"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("9a450fd7-9321-48cf-8d3f-f09ccbf0eed5"),
                            ItemCategoryName = "Hoodie"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("be63f0cc-e30b-495e-a6ab-839fb3009e94"),
                            ItemCategoryName = "Teddy Bear"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("08bf3344-9b77-410f-b313-30980d5673ea"),
                            ItemCategoryName = "LEGO Bricks"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("bd414305-8be4-4fd4-b77a-26b3700df732"),
                            ItemCategoryName = "Ball"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("3fabdc8a-1098-465d-b8a6-88d51bc30f80"),
                            ItemCategoryName = "Barbie doll"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("7499a8ed-40cf-43b6-99a4-44b15de3c713"),
                            ItemCategoryName = "Apple"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("7d1fc029-1d5f-4772-9291-06840046f661"),
                            ItemCategoryName = "Potato"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("aeaa1ccf-a11d-40a4-8244-1fba5e9414d4"),
                            ItemCategoryName = "Lemon"
                        },
                        new
                        {
                            ItemCategoryId = new Guid("d6cae0f9-9ecc-4da5-99a0-942c7c1b816a"),
                            ItemCategoryName = "Orange"
                        });
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemTransaction", b =>
                {
                    b.Property<Guid>("ItemTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PriceItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemTransactionId");

                    b.HasIndex("ItemId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Transaction_Items");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Shop", b =>
                {
                    b.Property<Guid>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopId");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ShopCategory", b =>
                {
                    b.Property<Guid>("ShopCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShopCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShopCategoryId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopCategory");

                    b.HasData(
                        new
                        {
                            ShopCategoryId = new Guid("9a4e92d2-a381-431e-bb02-a6874026cf65"),
                            ShopCategoryName = "ClothesShop"
                        },
                        new
                        {
                            ShopCategoryId = new Guid("9ddd8d30-9b93-41aa-b63a-d583efcfd700"),
                            ShopCategoryName = "ToysShop"
                        },
                        new
                        {
                            ShopCategoryId = new Guid("034b55fd-2941-4244-bb02-5a74564629b7"),
                            ShopCategoryName = "FoodShop"
                        });
                });

            modelBuilder.Entity("ShoppingCenter.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TransactionId");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingCenter.Models.CustomerShoppingCart", b =>
                {
                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShoppingCenter.Models.CustomerShoppingCartItem", b =>
                {
                    b.HasOne("ShoppingCenter.Models.CustomerShoppingCart", "CustomerShoppingCart")
                        .WithMany("CustomerShoppingCartItems")
                        .HasForeignKey("CustomerShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingCenter.Models.Item", "Item")
                        .WithMany("CustomerShoppingCartItem")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerShoppingCart");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemCategory", b =>
                {
                    b.HasOne("ShoppingCenter.Models.Item", null)
                        .WithMany("Categories")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemTransaction", b =>
                {
                    b.HasOne("ShoppingCenter.Models.Item", "Item")
                        .WithMany("ItemTransactions")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingCenter.Models.Transaction", "Transaction")
                        .WithMany("ItemsTransaction")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ShopCategory", b =>
                {
                    b.HasOne("ShoppingCenter.Models.Shop", null)
                        .WithMany("Categories")
                        .HasForeignKey("ShopId");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Transaction", b =>
                {
                    b.HasOne("ShoppingCenter.Areas.Identity.Data.ShoppingCenterUser", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ShoppingCenter.Models.CustomerShoppingCart", b =>
                {
                    b.Navigation("CustomerShoppingCartItems");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Item", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("CustomerShoppingCartItem");

                    b.Navigation("ItemTransactions");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Shop", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Transaction", b =>
                {
                    b.Navigation("ItemsTransaction");
                });
#pragma warning restore 612, 618
        }
    }
}
