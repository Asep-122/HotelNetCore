using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Mengirim pesan ke semua klien yang terhubung
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
