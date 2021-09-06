using ComHome.Hubs;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ComHome.Data {
    public class CHSensorService : IHostedService, IDisposable {
        private Timer timer;
        private readonly IHubContext<ChatHub> hub;

        public CHSensorService(IHubContext<ChatHub> hub) {
            this.hub = hub;
        }
        private void DoWork(object state) {
            hub.Clients.All.SendAsync("ReceiveMessage", "server", "server say: im alive");

            //что то тут опрашивается... куда то там добавляется....
        }

        public Task StartAsync(CancellationToken cancellationToken) {
            timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken) {
            timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
        public void Dispose() {
            timer?.Dispose();
        }

    }
}
