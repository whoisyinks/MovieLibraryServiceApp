using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieLibraryServiceApp.Models;

namespace MovieLibraryServiceApp.Data
{
    public class MovieLibraryServiceAppContext : DbContext
    {
        public MovieLibraryServiceAppContext (DbContextOptions<MovieLibraryServiceAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieLibraryServiceApp.Models.Movie> Movie { get; set; } = default!;
    }
}
