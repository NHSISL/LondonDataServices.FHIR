// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;
using LondonDataServices.FHIR.Core.Models.Bases;
using LondonDataServices.FHIR.Core.Models.Foundations.Consumers;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LondonDataServices.FHIR.Core.Models.Foundations.ConsumerAccesses
{
    public class ConsumerAccess : IKey, IAudit
    {
        public Guid Id { get; set; }
        public Guid ConsumerId { get; set; }
        public string OrgCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        [BindNever]
        public Consumer Consumer { get; set; } = null!;
    }
}
