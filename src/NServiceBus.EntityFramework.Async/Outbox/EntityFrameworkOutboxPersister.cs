// <copyright file="EntityFrameworkOutboxPersister.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

using System;
using System.Threading.Tasks;
using NServiceBus.Extensibility;
using NServiceBus.Outbox;

namespace NServiceBus.EntityFramework.Async.Outbox
{
    internal class EntityFrameworkOutboxPersister : IOutboxStorage
    {
        public Task<OutboxTransaction> BeginTransaction(ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task<OutboxMessage> Get(string messageId, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task SetAsDispatched(string messageId, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task Store(OutboxMessage message, OutboxTransaction transaction, ContextBag context)
        {
            throw new NotImplementedException();
        }
    }
}
