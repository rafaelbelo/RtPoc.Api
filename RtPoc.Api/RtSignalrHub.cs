using System;
using Microsoft.AspNetCore.SignalR;

namespace RtPoc.Api
{
    public class RtSignalrHub : Hub<IRealtimeMessage>
    {

    }
}