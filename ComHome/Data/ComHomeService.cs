using ComHome.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class ComHomeService : IHostedService, IDisposable {
        private Timer _timer;
        private readonly IHubContext<ChatHub> _hub;

        public ComHomeService(IHubContext<ChatHub> hub) {
            _hub = hub;
        }
        private void DoWork(object state) {
            _hub.Clients.All.SendAsync("ReceiveMessage", "server", "server say: im alive");

            //что то тут опрашивается... куда то там добавляется....
        }

        public Task StartAsync(CancellationToken cancellationToken) {
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken) {
            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
        public void Dispose() {
            _timer?.Dispose();
        }

    }
}
