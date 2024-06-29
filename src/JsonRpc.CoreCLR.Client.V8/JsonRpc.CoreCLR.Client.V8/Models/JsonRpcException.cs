using System.Text.Json.Serialization;

namespace JsonRpc.CoreCLR.Client.V8.Models;

public class JsonRpcException
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("data")]
    public object Data { get; set; }

    public JsonRpcException(int code, string message, object data)
    {
        this.Code = code;
        this.Message = message;
        this.Data = data;
    }
}