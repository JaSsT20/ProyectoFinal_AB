public class Context : DbContext
{
    #nullable disable
    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
}