using System;
using System.Runtime.Serialization;

using Domain.Core.Events;

namespace Domain.Client.Clients.Events
{
    [DataContract]
    public class LoyaltyCardWasReportedStolen : DomainEvent, ILoyaltyCardEvent
    {
        [DataMember(Order = 1, IsRequired = true, Name = "ClientId")]
        public ClientId ClientId { get; protected set; }

        [DataMember(Order = 2, IsRequired = true, Name = "CardNumber")]
        public LoyaltyCardNumber CardNumber { get; protected set; }

        public LoyaltyCardWasReportedStolen(ClientId clientId, LoyaltyCardNumber identity)
        {
            ClientId = clientId;
            CardNumber = identity;
        }

        public override string ToString()
        {
            return String.Format("Client {0} loyalty card {1} was reported stolen.", ClientId.Id, CardNumber.Id);
        }
    }
}