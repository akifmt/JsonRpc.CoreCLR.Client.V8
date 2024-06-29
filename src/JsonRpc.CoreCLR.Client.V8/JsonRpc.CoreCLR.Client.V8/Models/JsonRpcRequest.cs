using System.Text.Json.Serialization;

namespace JsonRpc.CoreCLR.Client.V8.Models;

public class JsonRpcRequest
{
    [JsonIgnore]
    public bool IsNotification { get; set; }

    [JsonPropertyName("jsonrpc")]
    public string JsonRpc
    { get { return "2.0"; } }

    [JsonPropertyName("method")]
    public string Method { get; set; }

    /// <summary>
    /// Params can be an array of values for positional arguments,
    /// or an object for named arguments
    /// </summary>
    [JsonPropertyName("params")]
    public object Params { get; set; }

    [JsonPropertyName("id")]
    public object Id { get; set; }
}