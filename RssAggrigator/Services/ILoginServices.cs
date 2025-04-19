using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RssAggrigator.Dto;


namespace RssAggrigator.Services
{
    public interface ILoginServices
    {
        Task<LoginResponse> LoginAsync(LoginRequest request); 
    }
}