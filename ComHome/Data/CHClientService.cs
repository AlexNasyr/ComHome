using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ComHome.Data {
    public class CHClientService {
        private IComHomeRepository repository;
        public CHClientService(IComHomeRepository repo) {
            repository = repo;
        }
        public Task<int> GetSomeData() => Task.FromResult(5);
        public Task<string> GetHistorical() => Task.FromResult(repository.GetHistoricalMeasurements());
        
        
        public Task<bool> InsertSensor() => Task.FromResult(repository.AddSensor(new Sensor() { SensorUID = "999", SensorName = "HallTermometer", SensorType = SensorType.Temperature}));


    }
}
