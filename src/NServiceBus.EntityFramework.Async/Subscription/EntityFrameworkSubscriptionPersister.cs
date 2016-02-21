// <copyright file="EntityFrameworkSubscriptionPersister.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NServiceBus.Extensibility;
using NServiceBus.Unicast.Subscriptions;
using NServiceBus.Unicast.Subscriptions.MessageDrivenSubscriptions;

namespace NServiceBus.EntityFramework.Async.Subscription
{
    internal class EntityFrameworkSubscriptionPersister : ISubscriptionStorage
    {
        public Task<IEnumerable<Subscriber>> GetSubscriberAddressesForMessage(IEnumerable<MessageType> messageTypes, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task Subscribe(Subscriber subscriber, MessageType messageType, ContextBag context)
        {
            throw new NotImplementedException();
        }

        public Task Unsubscribe(Subscriber subscriber, MessageType messageType, ContextBag context)
        {
            throw new NotImplementedException();
        }
    }
}
