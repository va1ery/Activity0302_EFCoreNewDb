using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryDatabaseCore
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options)
        : base()
        {
        }
    }
}
