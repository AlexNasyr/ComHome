using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class DbMsSqlContext : DbContext, IComHomeDBContext {
        private DbContextOptions options;
        public DbMsSqlContext(DbContextOptions<DbMsSqlContext> options) : base(options) {
            this.options = options;
        }

        //DBSet here
    }
}
