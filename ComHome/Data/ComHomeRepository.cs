using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class ComHomeRepository : IComHomeRepository {
        private DbPgContext dbContext;
        public ComHomeRepository(DbPgContext context) {
            dbContext = context;
        }
        public ComHomeRepository() {
        }

        public string AddSensor(Sensor sensor) {
            dbContext.Sensors.Add(sensor);
            dbContext.SaveChanges();
            return "success";
        }

        public string GetHistoricalMeasurements() {
            return $"historical data from DB with connStr {dbContext}";
        }
    }
}
