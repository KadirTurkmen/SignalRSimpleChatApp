using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRSimpleChatApp.Hubs
{
    [HubName("ds")]
    public class ChatHub : Hub
    {
        // ChatHub Sınıfımız Hub Sınıfından türetiliyor.

        public void SendMessage(string sendName, string receiveName, string message)
        {
            Clients.All.SendMessageToPage(sendName, receiveName, message); // Client taraftaki fonksiyonu tetikliyoruz.
        }
    }
}