using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace EntityTest
{
    public class MyChatHub : Hub
    {
        public override Task OnConnected()
        {
            Clients.All.User(Context.User.Identity.Name);
            return base.OnConnected();
        }

        public void Send(string message)
        {
            Clients.Caller.Message("You: " + message);
            Clients.Others.Message(Context.User.Identity.Name + ": " + message);
        }
    }
}