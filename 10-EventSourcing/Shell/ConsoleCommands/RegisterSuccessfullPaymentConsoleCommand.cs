﻿using Domain.Client.Accounts;
using Domain.Client.Accounts.Commands;
using Domain.Client.ValueObjects;
using System;

namespace Shell.ConsoleCommands
{
    class RegisterSuccessfullPaymentConsoleCommand : RegisterSuccessfullPayment, IConsoleCommand
    {
        public string[] Keys
        {
            get { return new[] { "RegisterPayment" }; }
        }

        public string Usage
        {
            get { return "RegisterPayment <AccountNumber> <amount>"; }
        }

        public void Build(string[] args)
        {
            if (args.Length != 2)
            {
                throw new Exception(String.Format("Error. Usage is: {0}", Usage));
            }

            AccountNumber = new AccountNumber(args[0]);
            BillingResult = BillingResult.PaymentMade(Decimal.Parse(args[1]), DateTime.Today);
        }
    }
}
