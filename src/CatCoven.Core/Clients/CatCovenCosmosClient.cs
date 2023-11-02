// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.Configuration;
using Microsoft.Azure.Cosmos;

namespace CatCoven.Core.Clients;

public class CatCovenCosmosClient : ICatCovenCosmosClient
{
    private readonly Container _container;

    public Container GetContainer() => _container;

    public CatCovenCosmosClient(IServiceConfiguration configuration)
    {
        var client = new CosmosClient(configuration.CosmosEndpoint, configuration.CosmosKey);
        _container = client.GetContainer(configuration.CosmosDatabase, configuration.CosmosContainer);
    }
}
