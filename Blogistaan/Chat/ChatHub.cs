//using Blogistaan.
//using Microsoft.AspNet.SignalR;

using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;



    //public void SendMessage(string user, string message)
    //{
    //    // Broadcast the message to all connected clients
    //    Clients.All.ReceiveMessage(user, message);
    //    Clients.All.Recei
    //}

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

