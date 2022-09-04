﻿using Account.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.DAL.Interfaces
{
    internal interface IAccountRepository
    {
        Task<bool> CreateCustomer(CustomerEntity customer);
        Task<bool> CreateAccount(AccountEntity account);
        Task<bool> CheckUniqueEmail(string email);
        Task<bool> CheckEmailExists(string email);
        Task<bool> CheckPasswordValid(string email, string password);
        Task<int> GetAccountIdByEmailAndPassword(string email);
        Task<AccountEntity> GetAccountInfoByAccountID(int id);

    }
}