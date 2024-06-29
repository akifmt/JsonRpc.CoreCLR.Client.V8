namespace JsonRpc.CoreCLR.Client.V8.Interfaces;

public interface IIdGenerator
{
    Task<object> GenerateId();
}