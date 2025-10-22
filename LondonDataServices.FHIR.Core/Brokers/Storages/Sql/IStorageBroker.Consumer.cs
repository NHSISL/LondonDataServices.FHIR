// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using LondonDataServices.FHIR.Core.Models.Foundations;

namespace LondonDataServices.FHIR.Core.Brokers.Storages.Sql
{
    public partial interface IStorageBroker
    {
        ValueTask<Consumer> InsertConsumerAsync(Consumer consumer);
        ValueTask<IQueryable<Consumer>> SelectAllConsumersAsync();
        ValueTask<Consumer> SelectConsumerByIdAsync(Guid consumerId);
        ValueTask<Consumer> UpdateConsumerAsync(Consumer consumer);
        ValueTask<Consumer> DeleteConsumerAsync(Consumer consumer);
    }
}
