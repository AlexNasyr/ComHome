using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class DbPgContext : DbContext, IComHomeDBContext {
        public DbPgContext(DbContextOptions<DbPgContext> options) : base(options) {
        }

        public DbSet<Sensor> Sensors { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Sensor>(entity => {
        //        entity.Property(e => e.SensorName).HasColumnType("NCHAR").HasMaxLength(32).IsRequired();
        //        entity.Property(e => e.SensorUID).HasColumnType("NCHAR").HasMaxLength(32);
        //        //entity.Property(e => e.SensorType).HasColumnType("NCHAR").HasMaxLength(32);
        //    });
        //}
    }
}
