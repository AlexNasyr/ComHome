using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class ComHomeRepository : IComHomeRepository {
        //private DbMssqlContext context;
        //private DbPgContext context;
        private IComHomeDBContext context;
        //public ComHomeRepository(DbMssqlContext dbContext) {
        //public ComHomeRepository(DbPgContext dbContext) {
        public ComHomeRepository(IComHomeDBContext dbContext) {
            context = dbContext;
        }
        public ComHomeRepository() {
        }

        public bool AddSensor(Sensor sensor) {
            context.Sensors.Add(sensor);
            (context as DbContext).SaveChanges();
            return true;
        }

        public string GetHistoricalMeasurements() {
            return $"historical data from DB with connStr {(context as DbContext).Database.GetDbConnection()}";
        }
    }
}
