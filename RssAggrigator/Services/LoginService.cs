using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RssAggrigator.Db;
using RssAggrigator.Dto;

namespace RssAggrigator.Services
{
    public class LoginService : ILoginServices
    {
        private readonly Context _context;

        public LoginService(Context context)
        {
            _context = context;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            throw new NotImplementedException();
        }
    }
}