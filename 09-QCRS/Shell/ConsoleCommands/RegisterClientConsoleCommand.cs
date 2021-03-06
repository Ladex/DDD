﻿using Domain.Client.Clients.Commands;
using Domain.Client.ValueObjects;
using System;

namespace Shell.ConsoleCommands
{
    class RegisterClientConsoleCommand : RegisterClient, IConsoleCommand
    {
        public string[] Keys
        {
            get { return new[] { "RegisterClient" }; }
        }

        public string Usage
        {
            get { return "RegisterClient <FirstName> <Surname> <IdentityNumber> <PrimaryContactNumber>"; }
        }

        public void Build(string[] args)
        {
            if (args.Length != 4)
            {
                throw new Exception(String.Format("Error. Usage is: {0}", Usage));
            }

            ClientName = new PersonName(args[0], args[1]);
            IdentityNumber = new IdentityNumber(args[2]);
            PrimaryContactNumber = new TelephoneNumber(args[3]);
        }
    }
}
