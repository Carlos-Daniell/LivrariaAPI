﻿using LivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Data {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }


}
