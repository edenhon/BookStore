using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace BookStoreApp.API.Controllers
{
    [Authorize]
    public class BookHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Debug.WriteLine($"{Context.ConnectionId} is connected." );
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Debug.WriteLine($"{Context.ConnectionId} is disconnected.");
            return base.OnDisconnectedAsync(exception);
        }
    }
}
