// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using LondonDataServices.FHIR.Core.Models.Foundations.Consumers;
using Microsoft.EntityFrameworkCore;

namespace LondonDataServices.FHIR.Core.Brokers.Storages.Sql
{
    public partial class StorageBroker
    {
        public DbSet<Consumer> Consumers { get; set; }

        public async ValueTask<Consumer> InsertConsumerAsync(Consumer consumer) =>
            throw new NotImplementedException();

        public async ValueTask<IQueryable<Consumer>> SelectAllConsumersAsync() =>
            throw new NotImplementedException();

        public async ValueTask<Consumer> SelectConsumerByIdAsync(Guid consumerId) =>
            throw new NotImplementedException();

        public async ValueTask<Consumer> UpdateConsumerAsync(Consumer consumer) =>
            throw new NotImplementedException();

        public async ValueTask<Consumer> DeleteConsumerAsync(Consumer consumer) =>
            throw new NotImplementedException();
    }
}
