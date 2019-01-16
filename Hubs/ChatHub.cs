using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatHub.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string test)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
