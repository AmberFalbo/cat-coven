﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.Models;
using CatCoven.Core.ServiceContracts.MewMewMaterials;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;

namespace CatCoven.Core.Clients
{
    public class MewMewMaterialsClient : IMewMewMaterialsClient
    {
        private readonly IMewMewMaterialsService _client;

        public MewMewMaterialsClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7064");
            _client = channel.CreateGrpcService<IMewMewMaterialsService>();
        }

        public Task<Cache> AddMaterials(List<Reagent> reagents)
        {
            // map reagents to request contract
            // call service
            // map response contract to cache

            throw new NotImplementedException();
        }

        public Task<Cache> GetCache(Guid meowMageId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ItLives()
        {
            throw new NotImplementedException();
        }

        public Task<Cache> UpdateCache(Cache cache)
        {
            throw new NotImplementedException();
        }
    }
}