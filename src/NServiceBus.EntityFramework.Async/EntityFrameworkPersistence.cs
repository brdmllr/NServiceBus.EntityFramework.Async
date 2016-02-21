// <copyright file="EntityFrameworkPersistence.cs" company="NServiceBus.EntityFramework.Async">
// Copyright 2016 Brad M. Miller
// </copyright>

namespace NServiceBus.EntityFramework.Async
{
    using Persistence;
    using NServiceBus.Features;
    using Features;

    /// <summary>
    /// Entry point for Entity Framework persistence.
    /// </summary>
    public class EntityFrameworkPersistence : PersistenceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkPersistence"/> class.
        /// </summary>
        public EntityFrameworkPersistence()
        {
            this.Supports<StorageType.GatewayDeduplication>(s => s.EnableFeatureByDefault<EntityFrameworkGatewayPersistence>());
            this.Supports<StorageType.Outbox>(s => s.EnableFeatureByDefault<EntityFrameworkOutboxPersistence>());
            this.Supports<StorageType.Sagas>(s => s.EnableFeatureByDefault<EntityFrameworkSagaPersistence>());
            this.Supports<StorageType.Subscriptions>(s => s.EnableFeatureByDefault<EntityFrameworkSubscriptionPersistence>());
            this.Supports<StorageType.Timeouts>(s => s.EnableFeatureByDefault<EntityFrameworkTimeoutPersistence>());
        }
    }
}
