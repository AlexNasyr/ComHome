using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class DbMsSqlContext : DbContext {
        private string connectionString;
        public DbMsSqlContext(string connString) {
            connectionString = connString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //DBSet here
    }
}
