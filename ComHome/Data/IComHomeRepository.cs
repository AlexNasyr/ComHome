﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Data
{
    public interface IComHomeRepository {
        bool AddSensor(Sensor sensor);
        string GetHistoricalMeasurements();
    }
}
