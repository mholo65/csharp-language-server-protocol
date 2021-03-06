using System.Threading.Tasks;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

// ReSharper disable CheckNamespace

namespace OmniSharp.Extensions.LanguageServer.Protocol.Client
{
    public static class DeclarationExtensions
    {
        public static Task<LocationOrLocationLinks> Declaration(this ILanguageClientDocument mediator, DeclarationParams @params)
        {
            return mediator.SendRequest<DeclarationParams, LocationOrLocationLinks>(DocumentNames.Declaration, @params);
        }
    }
}
