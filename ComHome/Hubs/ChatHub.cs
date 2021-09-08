using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComHome.Hubs {
    public class ChatHub : Hub {
        public async Task SendMessage(string user, string message) {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task GetBigData() {
            string[] array = new string[] { "q", "w", "e" };
            await Clients.All.SendAsync("BigDataMessage", array);
        }
    }
}
