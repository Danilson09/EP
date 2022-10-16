using Domain.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    //when installing packages put errors in comment
    //right click on solution and add nuget packages and install the following
    /*
     1. entityframeworkcore 3.1.29
    2. entityframeworkcore.relational
    3. entityframeworkcore.sqlserver
    4. entityframeworkcore.tools
    5. microsoft.aspnetcore.identity.ui
    6. microsoft.aspnetcore.identity.entityframeworkcore
    */
    //note: shoppingcartcontext is an abstraction of the database

    public class ShoppingCartContext : IdentityDbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options)
           : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
