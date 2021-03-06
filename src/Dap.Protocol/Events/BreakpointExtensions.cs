using System;
using System.Threading;
using System.Threading.Tasks;
using OmniSharp.Extensions.DebugAdapter.Protocol.Requests;
using OmniSharp.Extensions.Embedded.MediatR;
using OmniSharp.Extensions.JsonRpc;

namespace OmniSharp.Extensions.DebugAdapter.Protocol.Events
{
    public static class BreakpointExtensions
    {
        public static void SendBreakpoint(this IDebugClient mediator, BreakpointEvent @event)
        {
            mediator.SendNotification(EventNames.Breakpoint, @event);
        }
    }
}
