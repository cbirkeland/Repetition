# Tips

## FruitContext

Skapa en fil FruitContext.cs med detta innehåll:

    public class FruitContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<FruitCategory> FruitCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = DemoWithOneProject2;");
            }
            
        }
    }


## DataAccess.cs

Skapa en fil DataAccess.cs med detta innehåll:

    public class DataAccess
    {
        private readonly FruitContext _context;

        public DataAccess()
        {
            _context = new FruitContext();
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }


## ClearDatabase

Gå igenom t.ex alla frukter med *foreach* och ta bort en frukt i taget.

Detta ger alla frukter:

    _context.Fruits

För att ta bort en frukt

    _context.Remove(...)

## AddCategoriesAndFruits

Skapa ett objekt t.ex FruitCategory

    var skenfrukt = new FruitCategory  ....

Lägg till en kategori i context

    _context.FruitCategories.Add(....)


## GetAll

Testa
   
    _context.Fruits

Använd *Include* om du får NullException

    _context.Fruits.Include(x=>....)



## GetFruitsInCategory

Använd *Include* om du får Nullexception
