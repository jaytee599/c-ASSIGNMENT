using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASSIGNMENNT_n01635556_joeltuffour.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        public string Get ()
        {
            return "Hello World";
        }
        public string Get(string id) => "Hello to" + id + " People";
    }
}

