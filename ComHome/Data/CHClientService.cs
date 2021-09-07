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
    }
}
