using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssAggrigator.Dto
{
    public record LoginResponse
    {
    public string Jwt {get;set;}
    public string Email{get; set;}
            
    }
}