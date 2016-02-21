// <copyright file="EntityFrameworkGatewayPersister.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

namespace NServiceBus.EntityFramework.Async.Gateway
{
    using System;
    using System.Threading.Tasks;
    using Extensibility;
    using NServiceBus.Gateway.Deduplication;

    internal class EntityFrameworkGatewayPersister : IDeduplicateMessages
    {
        public Task<bool> DeduplicateMessage(string clientId, DateTime timeReceived, ContextBag context)
        {
            throw new NotImplementedException();
        }
    }
}
