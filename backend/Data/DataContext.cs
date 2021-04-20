using Microsoft.EntityFrameworkCore;
using backend.models;

namespace backend.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<User> Users {get; set;}
        
    }
}