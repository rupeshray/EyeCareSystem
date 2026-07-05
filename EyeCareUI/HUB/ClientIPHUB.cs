using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace EyeCareUI.HUB
{
    public class ClientIPHUB:Hub
    {
        public static ConcurrentDictionary<string, string> Users = new ConcurrentDictionary<string, string>();

        public async Task Send(int count)
        {
            await Clients.All.SendAsync("updateUsersOnlineCount", count);
        }
        public override async Task OnConnectedAsync()
        {
            string clientID = Context.ConnectionId;
            string loginID = GetLoginID();

            if (!string.IsNullOrEmpty(loginID))
            {
                if (Users.TryGetValue(loginID, out string? oldClientID))
                {
                    // Logout old connection
                    await Clients.Client(oldClientID).SendAsync("logout");

                    Users.TryRemove(loginID, out _);
                }

                Users.TryAdd(loginID, clientID);
            }

            await Send(Users.Count);

            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            string loginID = GetLoginID();
            string clientID = Context.ConnectionId;

            if (!string.IsNullOrEmpty(loginID))
            {
                if (Users.TryGetValue(loginID, out string? oldClientID))
                {
                    if (oldClientID == clientID)
                    {
                        Users.TryRemove(loginID, out _);
                    }
                }
            }

            await Send(Users.Count);

            await base.OnDisconnectedAsync(exception);
        }
        private string GetLoginID()
        {
            return Context.GetHttpContext()?
                          .Request.Query["loginID"]
                          .ToString() ?? string.Empty;
        }
    }
}
