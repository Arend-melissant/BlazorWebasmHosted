using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Threading;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            for(int i=0; i<10; i++)
            {
                Thread.Sleep(500);
                await Clients.All.SendAsync("ReceiveMessage", user, message + $" ({i})");
            }
        }
    }
}