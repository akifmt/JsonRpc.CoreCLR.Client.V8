using JsonRpc.CoreCLR.Client.V8.Models;
using System.Net;

namespace JsonRpc.CoreCLR.Client.V8.Interfaces;

public interface IWebRequestPreProcessor
{
    Task PreProcessRequest(WebRequest webRequest, JsonRpcRequest rpcRequest);
}