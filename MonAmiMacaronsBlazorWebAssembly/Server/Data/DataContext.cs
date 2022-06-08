namespace MonAmiMacaronsBlazorWebAssembly.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

            new Product
            {
                Id = 1,
                Title = "Shoko Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://www.einfachbacken.de/sites/einfachbacken.de/files/styles/700_530/public/2020-03/macarons.jpg?h=4521fff0&itok=w8VpTt7p",
                Price = 19.99M,
                CategoryId = 1,
            },
            new Product
            {
                Id = 2,
                Title = " Citronen Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://img.chefkoch-cdn.de/rezepte/1659951274094329/bilder/802341/crop-600x400/macarons.jpg",
                Price = 15.99M,
                CategoryId = 2,
            },
            new Product
            {
                Id = 3,
                Title = "Vanilie Macarons",
                Description = "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.",
                ImageUrl = "https://www.kuechengoetter.de/uploads/media/630x630/00/80750-luftige-schoko-macarons.webp?v=2-15",
                Price = 16.99M,
                CategoryId = 3,
            }

                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Macarons", Url = "macarons" },
                new Category { Id = 2, Name = "Cakes", Url = "cakes" },
                new Category { Id = 3, Name = " Choux pastry", Url = "choux-pastry" }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
