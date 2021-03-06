using System;
using Domain.Client.Events;
using Domain.Client.ValueObjects;
using Domain.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.ClientSpecifications
{
    [TestClass]
    // ReSharper disable InconsistentNaming
    public class When_client_date_of_birth_is_corrected : ClientSpecification
    {
        [TestMethod]
        public void With_a_valid_bith_date()
        {
            var dateOfBirth = new DateOfBirth(DateTime.Today.Date.AddYears(-18));

            Given(ClientRegistered());
            When(client => client.CorrectDateOfBirth(dateOfBirth));
            Then(new ClientDateOfBirthCorrected(DefaultClientId, dateOfBirth));
        }

        [TestMethod]
        public void With_an_invalid_birth_date()
        {
            var dateOfBirth = new DateOfBirth(DateTime.Today.Date);

            Given(ClientRegistered());
            When(client => client.CorrectDateOfBirth(dateOfBirth));
            Then<DomainError>("underage");
        }
    }
}
