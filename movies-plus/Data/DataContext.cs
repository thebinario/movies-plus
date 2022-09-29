using Microsoft.EntityFrameworkCore;
using System;
using webApi.Models;

namespace webApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Movies> Movies { get; set; }
        
    }
}