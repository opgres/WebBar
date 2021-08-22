﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models.E
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();//проверяется есть ли бд, если нет создает ее
            
        }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
