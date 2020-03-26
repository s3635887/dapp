using Microsoft.EntityFrameworkCore;
using DattingApp.api.Models;
using DattingApp.API.Models;

namespace DattingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}


        public DbSet<Value> Values { get; set; }

        public DbSet<User> User { get; set; }
    }
}