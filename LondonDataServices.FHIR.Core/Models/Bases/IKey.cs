// ---------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------

using System;

namespace LondonDataServices.FHIR.Core.Models.Bases
{
    public interface IKey
    {
        Guid Id { get; set; }
    }
}
