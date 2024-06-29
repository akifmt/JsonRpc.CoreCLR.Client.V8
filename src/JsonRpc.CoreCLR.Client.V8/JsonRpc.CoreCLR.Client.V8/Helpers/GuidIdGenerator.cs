using JsonRpc.CoreCLR.Client.V8.Interfaces;

namespace JsonRpc.CoreCLR.Client.V8.Helpers;

public class GuidIdGenerator : IIdGenerator
{
    public async Task<object> GenerateId()
    {
        return await Task.FromResult(Guid.NewGuid().ToString());
    }
}