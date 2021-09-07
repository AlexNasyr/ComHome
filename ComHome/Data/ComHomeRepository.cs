using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class ComHomeRepository : IComHomeRepository {
        private string connectionString;
        public ComHomeRepository(string connString) {
            connectionString = connString;
        }
        public ComHomeRepository() {
        }
        public string GetHistoricalMeasurements() {
            return $"historical data from DB with connStr {connectionString}";
        }
    }
}
