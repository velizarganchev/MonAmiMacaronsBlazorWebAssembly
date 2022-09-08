namespace MonAmiMacaronsBlazorWebAssembly.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(x => new { x.ProductId, x.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
               new ProductType
               {
                   Id = 1,
                   Name = "7 pieces"

               },
               new ProductType
               {
                   Id = 2,
                   Name = "11 pieces"

               },
               new ProductType
               {
                   Id = 3,
                   Name = "15 pieces"

               },
               new ProductType
               {
                   Id = 4,
                   Name = "19 pieces"

               },
               new ProductType
               {
                   Id = 5,
                   Name = "23 pieces"

               });

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 11.99M,
                    OriginalPrice = 19.99M

                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 13.99M,
                    OriginalPrice = 17.99M

                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 12.99M,
                    OriginalPrice = 18.99M

                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 7.99M,
                    OriginalPrice = 10.99M

                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 4,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 4,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 3,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 5,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 1,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 2,
                    Price = 20.99M,
                    OriginalPrice = 22.99M

                });

            modelBuilder.Entity<Product>().HasData(

            new Product
            {
                Id = 1,
                Title = "Shoko Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://www.einfachbacken.de/sites/einfachbacken.de/files/styles/700_530/public/2020-03/macarons.jpg?h=4521fff0&itok=w8VpTt7p",
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                Title = " Citronen Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/triple-chocolate-peanut-butter-layer-cake-2-06eee24.jpg",
                CategoryId = 2,
            },
            new Product
            {
                Id = 3,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://www.abakingjourney.com/wp-content/uploads/2019/08/Choux-a-la-Creme-Feature2-500x500.jpg",
                CategoryId = 3,
            },
            new Product
            {
                Id = 4,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/triple-chocolate-peanut-butter-layer-cake-2-06eee24.jpg",
                CategoryId = 2,
            },
            new Product
            {
                Id = 5,
                Title = " Banane Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/triple-chocolate-peanut-butter-layer-cake-2-06eee24.jpg",
                CategoryId = 2,
            },
            new Product
            {
                Id = 6,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Macarons%2C_French_made_mini_cakes.JPG/800px-Macarons%2C_French_made_mini_cakes.JPG",
                CategoryId = 1,
            },
            new Product
            {
                Id = 7,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://www.abakingjourney.com/wp-content/uploads/2019/08/Choux-a-la-Creme-Feature2-500x500.jpg",
                CategoryId = 3,
            },
            new Product
            {
                Id = 8,
                Title = "Shoko Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/triple-chocolate-peanut-butter-layer-cake-2-06eee24.jpg",
                CategoryId = 2,
            },
            new Product
            {
                Id = 9,
                Title = " Citronen Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/triple-chocolate-peanut-butter-layer-cake-2-06eee24.jpg",
                CategoryId = 2,
            },
            new Product
            {
                Id = 10,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Macarons%2C_French_made_mini_cakes.JPG/800px-Macarons%2C_French_made_mini_cakes.JPG",
                CategoryId = 1,
            }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Macarons", Url = "macarons" },
                new Category { Id = 2, Name = "Cakes", Url = "cakes" },
                new Category { Id = 3, Name = " Choux pastry", Url = "choux-pastry" }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        

    }
}
