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

        public int GetSomeData() => 5;
    }
}
