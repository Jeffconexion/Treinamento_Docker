﻿using Microsoft.EntityFrameworkCore;

namespace AppMVC.Models
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Produto> Produtos { get; set; }
  }
}
