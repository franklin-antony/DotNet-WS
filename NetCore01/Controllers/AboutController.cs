using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore01.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {

        
        public String Phone()
        {
            return "12345678";
        }


        
        public String Address()
        {
            return "INDIA";
        }
    }
}
