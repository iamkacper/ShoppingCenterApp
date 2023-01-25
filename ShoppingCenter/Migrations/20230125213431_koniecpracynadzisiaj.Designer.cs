﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCenter.Areas.Identity.Data;

#nullable disable

namespace ShoppingCenter.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20230125213431_koniecpracynadzisiaj")]
    partial class koniecpracynadzisiaj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ItemItemCategory", b =>
                {
                    b.Property<Guid>("CategoriesItemCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("itemsItemId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesItemCategoryId", "itemsItemId");

                    b.HasIndex("itemsItemId");

                    b.ToTable("ItemItemCategory");
                });

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

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.HasKey("CustomerShoppingCartItemId");

                    b.HasIndex("CustomerShoppingCartId");

                    b.HasIndex("ItemId1");

                    b.ToTable("CustomerShoppingCartItems");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("ColourItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SizeItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ColorItem = "WHITE",
                            DescriptionItem = "Unisex t-shirt",
                            NameItem = "T shirt",
                            PriceItem = 49m,
                            SizeItem = "S",
                            Url = "https://sklep.lahtipro.pl/1355-thickbox_default/koszulka-t-shirt-bawelniana-biala-lahti-pro-l40204.jpg"
                        },
                        new
                        {
                            ItemId = 2,
                            ColorItem = "BLACK",
                            DescriptionItem = "Unisex t-shirt",
                            NameItem = "T shirt",
                            PriceItem = 49m,
                            SizeItem = "M",
                            Url = "https://sklep.lahtipro.pl/1281-large_default/koszulka-t-shirt-bawelniana-czarna-lahtipro-l40205.jpg"
                        },
                        new
                        {
                            ItemId = 3,
                            ColorItem = "BLUE WITH PRINT",
                            DescriptionItem = "T-shirt for men",
                            NameItem = "T shirt",
                            PriceItem = 89m,
                            SizeItem = "L",
                            Url = "https://duzylolek.pl/userdata/public/gfx/6120/koszulka-t-shirt-duze-rozmiary-3XL-4XL-5XL-Adamo-modna-wygodna-dla-mezczyzn-plus-size-napisy-6XL-7XL-8XL-9XL-10XL-12XL.jpg"
                        },
                        new
                        {
                            ItemId = 4,
                            ColorItem = "Black",
                            DescriptionItem = "Trousers for men",
                            NameItem = "Trousers",
                            PriceItem = 89m,
                            SizeItem = "42",
                            Url = "https://image-resizing.booztcdn.com/selected-homme/sel16051390_cblack_v179099.webp?has_grey=1&has_webp=0&size=w1300"
                        },
                        new
                        {
                            ItemId = 5,
                            ColorItem = "Green",
                            DescriptionItem = "Jacket for men",
                            NameItem = "Jacket",
                            PriceItem = 399m,
                            SizeItem = "L",
                            Url = "https://dankyshop.pl/wp-content/uploads/2022/12/2-1.png"
                        },
                        new
                        {
                            ItemId = 18,
                            ColorItem = "Brown",
                            DescriptionItem = "Coat for men",
                            NameItem = "Coat",
                            PriceItem = 689m,
                            SizeItem = "M",
                            Url = "https://img01.ztat.net/article/spp-media-p1/6e81c667c70f3155b0851ea7f7ce6d1b/c82119333c6242c18428763270c25a17.jpg?imwidth=1800&filter=packshot"
                        },
                        new
                        {
                            ItemId = 6,
                            DescriptionItem = "Brick for children from 12 years of age.",
                            NameItem = "LEGO",
                            PriceItem = 3159m,
                            SizeItem = "7541 bricks",
                            Url = "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/27/2746003/LEGO-Star-Wars-Sokol-Millennium-75192-pudelko-zestaw.jpg"
                        },
                        new
                        {
                            ItemId = 7,
                            DescriptionItem = "Brick for children from 12 years of age.",
                            NameItem = "LEGO",
                            PriceItem = 389m,
                            SizeItem = "834",
                            Url = "https://m.media-amazon.com/images/I/611NGqFr1JL._AC_SX522_.jpg"
                        },
                        new
                        {
                            ItemId = 8,
                            DescriptionItem = "A great gift for a child",
                            NameItem = "TEDDY BEAR",
                            PriceItem = 39m,
                            SizeItem = "60cm",
                            Url = "https://target.scene7.com/is/image/Target/GUEST_27556c59-356f-44c0-9142-0bf4465e116c?wid=488&hei=488&fmt=pjpeg"
                        },
                        new
                        {
                            ItemId = 9,
                            DescriptionItem = "A great gift for a child",
                            NameItem = "TEDDY BEAR",
                            PriceItem = 99m,
                            SizeItem = "120cm",
                            Url = "https://cdn.shopify.com/s/files/1/0073/4740/4882/products/IMG_0476_0e28708a-6fc1-4c8a-afb1-43ce0924b52d_2592x.jpg?v=1630514970"
                        },
                        new
                        {
                            ItemId = 10,
                            DescriptionItem = "A great gift for a girl",
                            NameItem = "DOLL",
                            PriceItem = 189m,
                            SizeItem = "40cm",
                            Url = "https://image.ceneostatic.pl/data/article_picture/31/d6/7d6d-6663-4ca2-96de-f3ca303412c6_large.png"
                        },
                        new
                        {
                            ItemId = 11,
                            DescriptionItem = "A great gift for a future footballer",
                            NameItem = "PLUSH BALL",
                            PriceItem = 56m,
                            SizeItem = "M",
                            Url = "https://a.allegroimg.com/s1024/0cbed4/dfcc714144feb7d863cacfa4b2c9"
                        },
                        new
                        {
                            ItemId = 12,
                            DescriptionItem = "Healthy, not sprayed",
                            NameItem = "Banana",
                            PriceItem = 2m,
                            Url = "https://media.istockphoto.com/id/619046500/pl/zdj%C4%99cie/banany.jpg?s=612x612&w=0&k=20&c=44UgqVhiRpE94HbvM2-3i3VrZnRS_cLYdYOroV8LTIo="
                        },
                        new
                        {
                            ItemId = 13,
                            DescriptionItem = "From a Polish orchard",
                            NameItem = "Apple",
                            PriceItem = 1m,
                            Url = "https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg"
                        },
                        new
                        {
                            ItemId = 14,
                            DescriptionItem = "From a Polish orchard",
                            NameItem = "Apple juice",
                            PriceItem = 5m,
                            Url = "https://wspolceznatura.pl/userdata/public/gfx/2125/Sok-Jablkowy-Tloczony-Premium-4x5l.jpg"
                        },
                        new
                        {
                            ItemId = 15,
                            DescriptionItem = "From Poland",
                            NameItem = "Potato",
                            PriceItem = 21m,
                            Url = "https://www.poradnia.pl/images/stories/artykuly/ziemniak.jpg"
                        },
                        new
                        {
                            ItemId = 16,
                            DescriptionItem = "From Poland",
                            NameItem = "Tomato",
                            PriceItem = 23m,
                            Url = "https://profit.sklepkupiec.pl/17852-thickbox_default/pomidor-import.jpg"
                        },
                        new
                        {
                            ItemId = 17,
                            DescriptionItem = "From Poland",
                            NameItem = "Pumpkin",
                            PriceItem = 16m,
                            Url = "https://www.carrefour.pl/images/product/org/dynia-wazona-nlctjl.jpg"
                        });
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemCategory", b =>
                {
                    b.Property<Guid>("ItemCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemTransaction", b =>
                {
                    b.Property<Guid>("ItemTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<decimal>("PriceItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemTransactionId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("TransactionId");

                    b.ToTable("Transaction_Items");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopId");

                    b.ToTable("Shop");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Description = "Clothes shop, t-shirts, trouser and hoodies!",
                            Level = "0",
                            ShopName = "Clothes Shop"
                        },
                        new
                        {
                            ShopId = 2,
                            Description = "Toys shop, teddy bears, LEGO and many more toys for you!",
                            Level = "1",
                            ShopName = "Toys Shop"
                        },
                        new
                        {
                            ShopId = 3,
                            Description = "Food shop, vegetables, fruits, fresh juice.",
                            Level = "1",
                            ShopName = "Food Shop"
                        });
                });

            modelBuilder.Entity("ShoppingCenter.Models.ShopCategory", b =>
                {
                    b.Property<Guid>("ShopCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShopCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("ShopCategoryId");

                    b.HasIndex("ShopId");

                    b.ToTable("ShopCategory");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Shop_Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ShopId");

                    b.ToTable("Shop_Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 1,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 2,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 3,
                            ItemId = 3,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 4,
                            ItemId = 4,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 5,
                            ItemId = 5,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 18,
                            ItemId = 18,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 6,
                            ItemId = 6,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 7,
                            ItemId = 7,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 8,
                            ItemId = 8,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 9,
                            ItemId = 9,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 10,
                            ItemId = 10,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 11,
                            ItemId = 11,
                            ShopId = 2
                        },
                        new
                        {
                            Id = 12,
                            ItemId = 12,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 13,
                            ItemId = 13,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 14,
                            ItemId = 14,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 15,
                            ItemId = 15,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 16,
                            ItemId = 16,
                            ShopId = 3
                        },
                        new
                        {
                            Id = 17,
                            ItemId = 17,
                            ShopId = 3
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

            modelBuilder.Entity("ItemItemCategory", b =>
                {
                    b.HasOne("ShoppingCenter.Models.ItemCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesItemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingCenter.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("itemsItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                        .HasForeignKey("ItemId1");

                    b.Navigation("CustomerShoppingCart");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ShoppingCenter.Models.ItemTransaction", b =>
                {
                    b.HasOne("ShoppingCenter.Models.Item", "Item")
                        .WithMany("ItemTransactions")
                        .HasForeignKey("ItemId1");

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

            modelBuilder.Entity("ShoppingCenter.Models.Shop_Items", b =>
                {
                    b.HasOne("ShoppingCenter.Models.Item", "Item")
                        .WithMany("Shop_Items")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingCenter.Models.Shop", "Shop")
                        .WithMany("Shop_Items")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Shop");
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
                    b.Navigation("CustomerShoppingCartItem");

                    b.Navigation("ItemTransactions");

                    b.Navigation("Shop_Items");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Shop", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Shop_Items");
                });

            modelBuilder.Entity("ShoppingCenter.Models.Transaction", b =>
                {
                    b.Navigation("ItemsTransaction");
                });
#pragma warning restore 612, 618
        }
    }
}
