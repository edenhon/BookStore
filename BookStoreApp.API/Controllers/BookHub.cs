using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace BookStoreApp.API.Controllers
{
    public class BookHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Debug.WriteLine(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
