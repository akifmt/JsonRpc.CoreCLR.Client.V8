using JsonRpc.CoreCLR.Client.V8.Models;

namespace JsonRpc.CoreCLR.Client.V8.Interfaces;

public interface IJsonRpcClient
{
    /// <summary>
    /// Invokes the remote method using named arguments.
    /// Each field of the args object is an argument for the method.
    /// <param name="method">Name of method to invoke</param>
    /// <param name="args">Object with arguments to pass to invoked method</param>
    /// </summary>
    Task<JsonRpcResponse<T>> InvokeAsync<T>(string method, object args);

    /// <summary>
    /// Invokes the remote method using positional arguments
    /// <param name="method">Name of method to invoke</param>
    /// <param name="args">Array of arguments to pass to invoked method</param>
    /// </summary>
    Task<JsonRpcResponse<T>> InvokeAsync<T>(string method, object[] args);

    /// <summary>
    /// Invokes a remote method defined by the specified request
    /// <param name="jsonRpc">Definition of the remote method to invoke</param>
    /// </summary>
    Task<JsonRpcResponse<T>> InvokeAsync<T>(JsonRpcRequest jsonRpc);
}