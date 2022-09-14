﻿using Account.DAL.Entities;
using Account.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Account.DAL.Repositories
{
    public class EmailVerificationRepository : IEmailVerificationRepository
    {
        private readonly IDbContextFactory<AccountDBContext> _factory;
        public EmailVerificationRepository(IDbContextFactory<AccountDBContext> factory)
        {
            _factory = factory;
        }
        public async Task AddEmailVerification(EmailVerificationEntity emailVerificationEntity)
        {
            using var context = _factory.CreateDbContext();
            await context.Verifications.AddAsync(emailVerificationEntity);
            await context.SaveChangesAsync();
        }

       public async Task<bool> CheckVerificationAsync(string email, string verificationCode)
        {
            using var context = _factory.CreateDbContext();
            return await context.Verifications.AnyAsync(v=>v.Email.Equals(email)&&v.VerificationCode.Equals(verificationCode)&&v.ExpirationTime>=DateTime.UtcNow);
        }
    }
}
