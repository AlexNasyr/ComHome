﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class ComHomeRepository : IComHomeRepository {
        private DbContext dbContext;
        public ComHomeRepository(DbContext context) {
            dbContext = context;
        }

        //public ComHomeRepository() {
        //}
        //using dbcontext.dbsets here

        public string GetHistoricalMeasurements() {
            return $"historical data from DB with connStr {dbContext.Model}";
        }
    }
}
