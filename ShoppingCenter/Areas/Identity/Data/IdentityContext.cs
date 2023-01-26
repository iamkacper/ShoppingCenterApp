using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCenter.Areas.Identity.Data;
using ShoppingCenter.Models;

namespace ShoppingCenter.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<ShoppingCenterUser,IdentityRole,string>
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


        builder.Entity<Shop>().HasData(
           new Shop { ShopId = 1, ShopName = "Clothes Shop", Description = "Clothes shop, t-shirts, trouser and hoodies!", Level = "0" },
           new Shop { ShopId = 2, ShopName = "Toys Shop", Description = "Toys shop, teddy bears, LEGO and many more toys for you!", Level = "1" },
           new Shop { ShopId = 3, ShopName = "Food Shop", Description = "Food shop, vegetables, fruits, fresh juice.", Level = "1" }
           );

        builder.Entity<Item>().HasData(
            new Item { ItemId = 1,NameItem="T shirt",ColorItem="White",SizeItem="S",Url= "https://sklep.lahtipro.pl/1355-thickbox_default/koszulka-t-shirt-bawelniana-biala-lahti-pro-l40204.jpg", PriceItem = 49, DescriptionItem="Unisex t-shirt" },
            new Item { ItemId = 2,NameItem="T shirt",ColorItem="Black",SizeItem="M",Url= "https://sklep.lahtipro.pl/1281-large_default/koszulka-t-shirt-bawelniana-czarna-lahtipro-l40205.jpg", PriceItem = 49, DescriptionItem = "Unisex t-shirt" },
            new Item { ItemId = 3,NameItem="T shirt",ColorItem="Blue with print",SizeItem="L",Url= "https://duzylolek.pl/userdata/public/gfx/6120/koszulka-t-shirt-duze-rozmiary-3XL-4XL-5XL-Adamo-modna-wygodna-dla-mezczyzn-plus-size-napisy-6XL-7XL-8XL-9XL-10XL-12XL.jpg", PriceItem = 89, DescriptionItem = "T-shirt for men" },
            new Item { ItemId = 4,NameItem="Trousers",ColorItem="Black",SizeItem="42",Url= "https://image-resizing.booztcdn.com/selected-homme/sel16051390_cblack_v179099.webp?has_grey=1&has_webp=0&size=w1300", PriceItem = 89, DescriptionItem = "Trousers for men" },
            new Item { ItemId = 5,NameItem="Jacket",ColorItem="Green",SizeItem="L",Url= "https://dankyshop.pl/wp-content/uploads/2022/12/2-1.png", PriceItem = 399, DescriptionItem = "Jacket for men" },
            new Item { ItemId = 18,NameItem="Coat",ColorItem="Brown",SizeItem="M",Url= "https://img01.ztat.net/article/spp-media-p1/6e81c667c70f3155b0851ea7f7ce6d1b/c82119333c6242c18428763270c25a17.jpg?imwidth=1800&filter=packshot", PriceItem = 689, DescriptionItem = "Coat for men" },
            new Item { ItemId = 6,NameItem="LEGO",SizeItem= "7541 bricks", Url= "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/27/2746003/LEGO-Star-Wars-Sokol-Millennium-75192-pudelko-zestaw.jpg", PriceItem = 3159, DescriptionItem = "Brick for children from 12 years of age" },
            new Item { ItemId = 7,NameItem="LEGO",SizeItem="834 bricks",Url= "https://m.media-amazon.com/images/I/611NGqFr1JL._AC_SX522_.jpg", PriceItem = 389, DescriptionItem = "Brick for children from 12 years of ag."  },
            new Item { ItemId = 8,NameItem="TEDDY BEAR",SizeItem="60cm",Url= "https://target.scene7.com/is/image/Target/GUEST_27556c59-356f-44c0-9142-0bf4465e116c?wid=488&hei=488&fmt=pjpeg", PriceItem = 39, DescriptionItem = "A great gift for a child" },
            new Item { ItemId = 9,NameItem="TEDDY BEAR", SizeItem="120cm",Url= "https://cdn.shopify.com/s/files/1/0073/4740/4882/products/IMG_0476_0e28708a-6fc1-4c8a-afb1-43ce0924b52d_2592x.jpg?v=1630514970", PriceItem = 99, DescriptionItem = "A great gift for a child" },
            new Item { ItemId = 10,NameItem="DOLL", SizeItem="40cm",Url= "https://image.ceneostatic.pl/data/article_picture/31/d6/7d6d-6663-4ca2-96de-f3ca303412c6_large.png", PriceItem = 189, DescriptionItem = "A great gift for a girl" },
            new Item { ItemId = 11,NameItem="PLUSH BALL", SizeItem="M",Url= "https://a.allegroimg.com/s1024/0cbed4/dfcc714144feb7d863cacfa4b2c9", PriceItem = 56, DescriptionItem = "A great gift for a future footballer" },
            new Item { ItemId = 12,NameItem="Banana",Url= "https://media.istockphoto.com/id/619046500/pl/zdj%C4%99cie/banany.jpg?s=612x612&w=0&k=20&c=44UgqVhiRpE94HbvM2-3i3VrZnRS_cLYdYOroV8LTIo=", PriceItem = 2, DescriptionItem= "Healthy, not sprayed" },
            new Item { ItemId = 13,NameItem="Apple",Url= "https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg", PriceItem = 1, DescriptionItem= "From a Polish orchard" },
            new Item { ItemId = 14,NameItem="Apple juice",Url= "https://wspolceznatura.pl/userdata/public/gfx/2125/Sok-Jablkowy-Tloczony-Premium-4x5l.jpg", PriceItem = 5, DescriptionItem = "From a Polish orchard" },
            new Item { ItemId = 15,NameItem="Potato",Url= "https://www.poradnia.pl/images/stories/artykuly/ziemniak.jpg", PriceItem = 21, DescriptionItem = "From Poland" },
            new Item { ItemId = 16,NameItem="Tomato",Url= "https://profit.sklepkupiec.pl/17852-thickbox_default/pomidor-import.jpg", PriceItem = 23, DescriptionItem = "From Poland" },
            new Item { ItemId = 17,NameItem="Pumpkin",Url= "https://www.carrefour.pl/images/product/org/dynia-wazona-nlctjl.jpg", PriceItem = 16, DescriptionItem = "From Poland" }

            );
        builder.Entity<Shop_Items>().HasData(
            new Shop_Items() { Id = 1, ItemId = 1, ShopId = 1 },
            new Shop_Items() { Id = 2, ItemId = 2, ShopId = 1 },
            new Shop_Items() { Id = 3, ItemId = 3, ShopId = 1 },
            new Shop_Items() { Id = 4, ItemId = 4, ShopId = 1 },
            new Shop_Items() { Id = 5, ItemId = 5, ShopId = 1 },
            new Shop_Items() { Id = 18, ItemId = 18, ShopId = 1 },
            new Shop_Items() { Id = 6, ItemId = 6, ShopId = 2 },
            new Shop_Items() { Id = 7, ItemId = 7, ShopId = 2 },
            new Shop_Items() { Id = 8, ItemId = 8, ShopId = 2 },
            new Shop_Items() { Id = 9, ItemId = 9, ShopId = 2 },
            new Shop_Items() { Id = 10, ItemId = 10, ShopId = 2 },
            new Shop_Items() { Id = 11, ItemId = 11, ShopId = 2 },
            new Shop_Items() { Id = 12, ItemId = 12, ShopId = 3 },
            new Shop_Items() { Id = 13, ItemId = 13, ShopId = 3 },
            new Shop_Items() { Id = 14, ItemId = 14, ShopId = 3 },
            new Shop_Items() { Id = 15, ItemId = 15, ShopId = 3 },
            new Shop_Items() { Id = 16, ItemId = 16, ShopId = 3 },
            new Shop_Items() { Id = 17, ItemId = 17, ShopId = 3 }
            );


        builder.Entity<Item>().HasKey(e => e.ItemId);
        builder.Entity<Item>().Property(e => e.NameItem);
        builder.Entity<Item>().Property(e => e.PriceItem);
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
