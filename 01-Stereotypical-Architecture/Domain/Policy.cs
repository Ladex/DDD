﻿using System;

using Infrastructure;

namespace Domain
{
    /// <summary>
    /// A typical aneamic domain model. This really is just a DTO with no atual behaviour.
    /// </summary>
    public class Policy : IIntegerIdentity
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public decimal SumAssured { get; set; }
        public decimal Premium { get; set; }
        public DateTime CaptureDate { get; set; }
        public DateTime DateOfCommencement { get; set; }
        public bool IsActive { get; set; }
        public string PlanDescription { get; set; }
        public string PlanCode { get; set; }
        public string MasterContractNumber { get; set; }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
