// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using LondonDataServices.FHIR.Core.Models.Foundations.OdsDatas;
using Microsoft.EntityFrameworkCore;

namespace LondonDataServices.FHIR.Core.Brokers.Storages.Sql
{
    public partial class StorageBroker
    {
        public DbSet<OdsData> OdsDatas { get; set; }
    }
}
