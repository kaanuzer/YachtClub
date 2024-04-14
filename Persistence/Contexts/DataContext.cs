using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options) { }

        public DbSet<BrokerageFirm> BrokerageFirms { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerModel> ManufacturerModels { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Yacht> Yachts { get; set; }
        public DbSet<YachtCategory> YachtCategories { get; set; }
        public DbSet<YachtFeature> YachtFeatures { get; set; }
        public DbSet<YachtFeatureCategory> YachtFeatureCategories { get; set; }
        public DbSet<YachtImage> YachtImages { get; set; }
    }
}
