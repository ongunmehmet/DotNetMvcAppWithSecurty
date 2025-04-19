using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RssAggrigator.Db;
using RssAggrigator.Dto;
using RssAggrigator.Entity;

namespace RssAggrigator.Services
{
    public class AuthService : IAuthServices
    {
        private readonly Context _context;

        public AuthService(Context context)
        {
            _context = context;
        }

        public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
        {
               var newUser = new AppUser
            {
                Email = request.Email,
                Password = request.Password, // In production, hash this!
                Role = request.Role
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return new RegisterResponse
            {
                Id = newUser.Id,
                Email = newUser.Email
            };
        }
    }
}