// <copyright file="EntityFrameworkTimeoutPersister.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

using System;
using System.Threading.Tasks;
using NServiceBus.Extensibility;
using NServiceBus.Timeout.Core;

namespace NServiceBus.EntityFramework.Async.Timeout
{
    internal class EntityFrameworkTimeoutPersister : IPersistTimeouts, IQueryTimeouts
    {
        #region IPersistTimeouts

        public Task Add(TimeoutData timeout, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task<TimeoutData> Peek(string timeoutId, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task RemoveTimeoutBy(Guid sagaId, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TryRemove(string timeoutId, ContextBag context)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IQueryTimeouts

        public Task<TimeoutsChunk> GetNextChunk(DateTime startSlice)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
