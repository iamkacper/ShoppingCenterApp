using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCenter.Areas.Identity.Data;
using ShoppingCenter.Models;

namespace ShoppingCenter.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<ShoppingCenterUser>
{
    public DbSet<ItemCategory> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<ItemTransaction> Transaction_Items { get; set; }
    public DbSet<CustomerShoppingCart> CustomersShoppingCarts { get; set; }
    public DbSet<ShoppingCenterUser> Customers { get; set; }
    public DbSet<CustomerShoppingCartItem> CustomerShoppingCartItems { get; set; }
    public DbSet<Shop_Items> Shop_Items { get; set; }
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Shop_Items>()
            .HasOne(x => x.Shop)
            .WithMany(x => x.Shop_Items)
            .HasForeignKey(x => x.ShopId);

        builder.Entity<Shop_Items>()
            .HasOne(x => x.Item)
            .WithMany(x => x.Shop_Items)
            .HasForeignKey(x => x.ItemId);



        //builder.Entity<IdentityRole>().HasData(
        //    new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
        //    new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "ClothesShopAdmin", NormalizedName = "ClothesShopADMIN" },
        //    new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "ToysShopAdmin", NormalizedName = "ToysShopADMIN" },
        //    new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "FoodShopAdmin", NormalizedName = "FoodShopADMIN" },
        //    new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" }
        //    );

        //builder.Entity<ShopCategory>().HasData(
        //    new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "ClothesShop" },
        //    new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "ToysShop" },
        //    new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "FoodShop" }
        //    );

        builder.Entity<Shop>().HasData(
           new Shop { ShopId = 1, ShopName = "Clothes Shop", Description = "Clothes shop, t-shirts, trouser and hoodies!", Level = "0" },
           new Shop { ShopId = 2, ShopName = "Toys Shop", Description = "Toys shop, teddy bears, LEGO and many more toys for you!", Level = "1" },
           new Shop { ShopId = 3, ShopName = "Toys Shop", Description = "Food shop, vegetables, fruits, fresh juice.", Level = "1" }
           );

        builder.Entity<Item>().HasData(
            new Item { ItemId = 1,NameItem="T shirt",ColorItem="WHITE",SizeItem="S",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 59 },
            new Item { ItemId = 2,NameItem="T shirt",ColorItem="BLACK",SizeItem="M",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 7, PriceItem = 65 },
            new Item { ItemId = 3,NameItem="T shirt",ColorItem="BLUE WITH PRINT",SizeItem="L",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 79 },
            new Item { ItemId = 4,NameItem="Trousers",ColorItem="Black",SizeItem="42",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 99 },
            new Item { ItemId = 5,NameItem="Jacket",ColorItem="Green",SizeItem="44",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 129 },
            new Item { ItemId = 6,NameItem="LEGO",ColorItem="White",SizeItem="1000 bricks",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 59 },
            new Item { ItemId = 7,NameItem="LEGO",ColorItem="White",SizeItem="S",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 59 },
            new Item { ItemId = 8,NameItem="banana",ColorItem="White",SizeItem="S",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 59 },
            new Item { ItemId = 9,NameItem="apple",ColorItem="White",SizeItem="S",Url= "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", AvailabilityItem = 5, PriceItem = 59 }

            );
        builder.Entity<Shop_Items>().HasData(
            new Shop_Items() { Id = 1, ItemId = 1, ShopId = 1 },
            new Shop_Items() { Id = 2, ItemId = 2, ShopId = 1 },
            new Shop_Items() { Id = 3, ItemId = 3, ShopId = 1 },
            new Shop_Items() { Id = 4, ItemId = 4, ShopId = 1 },
            new Shop_Items() { Id = 5, ItemId = 5, ShopId = 1 },
            new Shop_Items() { Id = 6, ItemId = 6, ShopId = 2 },
            new Shop_Items() { Id = 7, ItemId = 7, ShopId = 2 },
            new Shop_Items() { Id = 8, ItemId = 8, ShopId = 3 },
            new Shop_Items() { Id = 9, ItemId = 9, ShopId = 3 }
            );


        builder.Entity<Item>().HasKey(e => e.ItemId);
        builder.Entity<Item>().Property(e => e.NameItem);
        builder.Entity<Item>().Property(e => e.PriceItem);
        builder.Entity<Item>().Property(e => e.AvailabilityItem);
        //builder.Entity<Item>().Property(e => e.ItemImageName);
        builder.Entity<Item>().Property(e => e.DescriptionItem);

        builder.Entity<Transaction>().HasKey(e => e.TransactionId);

        builder.Entity<ItemTransaction>().HasKey(e => e.ItemTransactionId);
        builder.Entity<ItemTransaction>().Property(e => e.PriceItem);

        builder.Entity<CustomerShoppingCartItem>().HasKey(e => e.CustomerShoppingCartItemId);

        builder.Entity<CustomerShoppingCart>().HasKey(e => e.CustomerId);

        builder.Entity<ShoppingCenterUser>().HasKey(e => e.Id);

        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<ShoppingCenter.Models.Shop> Shop { get; set; } = default!;
}
