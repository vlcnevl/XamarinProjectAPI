using Core.Entities.Concrete;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Hubs
{
    public class ChatHub : Hub
    {
        private static List<MessageUser> Users = new List<MessageUser>();

        //public async override Task OnConnectedAsync()
        //{
        //     await Groups.AddToGroupAsync(this.Context.ConnectionId, Context.User.Identity.Name);
        //}


        public async Task SetConnection(string userMail)
        {
            //await Clients.All.SendAsync("JoinChat", user);
            MessageUser user = new MessageUser();
            user.Mail = userMail;
            user.ConnectionId = Context.User.Identity.Name;
            Users.Add(user);
        }

        public async Task LeaveChat(string user)
        {
            await Clients.All.SendAsync("LeaveChat", user);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public async Task SendPrivateMessage(string user,string message)
        //{
            
        //}


        public async Task JoinGroup(string groupName)
        {
            await this.Groups.AddToGroupAsync(Context.ConnectionId, groupName);       
        }
        public async Task SendMessageGroup(string toUser, string fromUser, string message)
        {
            await this.Clients.Group(toUser).SendAsync("SendMessage", toUser, fromUser,message);
        }


    }
}
