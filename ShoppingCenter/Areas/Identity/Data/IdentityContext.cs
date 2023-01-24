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
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "ClothesShopAdmin", NormalizedName = "ClothesShopADMIN" },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "ToysShopAdmin", NormalizedName = "ToysShopADMIN" },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "FoodShopAdmin", NormalizedName = "FoodShopADMIN" },
            new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "User", NormalizedName = "USER" }
            );

        builder.Entity<ShopCategory>().HasData(
            new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "ClothesShop" },
            new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "ToysShop" },
            new ShopCategory { ShopCategoryId = Guid.NewGuid(), ShopCategoryName = "FoodShop" }
            );

        builder.Entity<ItemCategory>().HasData(
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "T-Shirt" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Trousers" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Shoes" }, 
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Hoodie" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Teddy Bear" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "LEGO Bricks" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Ball" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Barbie doll" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Apple" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Potato" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Lemon" },
            new ItemCategory { ItemCategoryId = Guid.NewGuid(), ItemCategoryName = "Orange" }
            );


        builder.Entity<Item>().HasKey(e => e.ItemId);
        builder.Entity<Item>().Property(e => e.NameItem);
        builder.Entity<Item>().Property(e => e.PriceItem);
        builder.Entity<Item>().Property(e => e.AvailabilityItem);
        builder.Entity<Item>().Property(e => e.ItemImageName);
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
