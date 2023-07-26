using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;
namespace FirstWebMVC.Data
{


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Animal> Animal { get; set; } = default!;

        public DbSet<Dog> Dog { get; set; } = default!;

        public DbSet<Cat> Cat { get; set; } = default!;

        public DbSet<Employee> Employee { get; set; } = default!;

        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Faculty> Faculty { get; set; } = default!;
        
        
    }
}