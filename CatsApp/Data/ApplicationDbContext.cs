﻿using CatsApp.Models;
using CatsForum.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CatsApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CatsModelEntity> CatsModelEntity { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
