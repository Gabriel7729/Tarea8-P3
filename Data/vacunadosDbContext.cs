using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Tarea8_P3.Data
{
    public class vacunadosDbContext : DbContext
    {
        #region Contructor
        public vacunadosDbContext(DbContextOptions<vacunadosDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<vacunados> Product { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<vacunados>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private List<vacunados> GetProducts()
        {
            return new List<vacunados>
            {
                
            };
        }
        #endregion
    }
}
