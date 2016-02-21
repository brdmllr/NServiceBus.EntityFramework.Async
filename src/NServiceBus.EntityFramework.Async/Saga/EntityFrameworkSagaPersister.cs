// <copyright file="EntityFrameworkSagaPersister.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

using System;
using System.Threading.Tasks;
using NServiceBus.Extensibility;
using NServiceBus.Persistence;
using NServiceBus.Sagas;

namespace NServiceBus.EntityFramework.Async.Saga
{
    internal class EntityFrameworkSagaPersister : ISagaPersister
    {
        public Task Complete(IContainSagaData sagaData, SynchronizedStorageSession session, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task<TSagaData> Get<TSagaData>(Guid sagaId, SynchronizedStorageSession session, ContextBag context)
            where TSagaData : IContainSagaData
        {
            throw new NotImplementedException();
        }

        public Task<TSagaData> Get<TSagaData>(string propertyName, object propertyValue, SynchronizedStorageSession session, ContextBag context)
            where TSagaData : IContainSagaData
        {
            throw new NotImplementedException();
        }

        public Task Save(IContainSagaData sagaData, SagaCorrelationProperty correlationProperty, SynchronizedStorageSession session, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task Update(IContainSagaData sagaData, SynchronizedStorageSession session, ContextBag context)
        {
            throw new NotImplementedException();
        }
    }
}
