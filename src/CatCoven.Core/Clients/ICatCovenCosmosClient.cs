// ------------------------------------
// Cat Coven API
// ------------------------------------

using Microsoft.Azure.Cosmos;

namespace CatCoven.Core.Clients;

public interface ICatCovenCosmosClient
{
    Container GetContainer();
}