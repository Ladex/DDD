﻿using Domain.Client.Accounts;
using Domain.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AccountNumberService : IAccountNumberService
    {
        public AccountNumber GetNextAccountNumber()
        {
            //normally we would connect to the database to get the next available account number.
            return new AccountNumber(String.Format("A{0}", DateTime.Now.Ticks));
        }
    }
}
