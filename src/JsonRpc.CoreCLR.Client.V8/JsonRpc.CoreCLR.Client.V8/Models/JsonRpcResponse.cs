using System.Text.Json.Serialization;

namespace JsonRpc.CoreCLR.Client.V8.Models;

public class JsonRpcResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc
    { get { return "2.0"; } }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public object Result { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public JsonRpcException Error { get; set; }

    [JsonPropertyName("id")]
    public object Id { get; set; }
}

public class JsonRpcResponse<T>
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc
    { get { return "2.0"; } }

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public T Result { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public JsonRpcException Error { get; set; }

    [JsonPropertyName("id")]
    public object Id { get; set; }
}