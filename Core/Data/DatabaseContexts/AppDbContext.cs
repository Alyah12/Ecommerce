﻿using Ecommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Context;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
}