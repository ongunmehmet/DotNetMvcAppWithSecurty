using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssAggrigator.Entity
{
    public class AppUser
    {
        public Guid Id {get ; set;}
        public String Email {get; set ;}

        public String Password {get; set ;}

        public String Role {get; set ;}
    }
}
