using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASSIGNMENNT_n01635556_joeltuffour.Controllers
{
    public class machineController : Controller
    {
        // GET: /<controller>/
        public int Get(int id)
        {
            if(id < 1)
            {
                return id + 10;
            }
            else if (id >= 1 && id <= 20)
            {
                return id * id;
            }
            else
            {
                return id / 2;
            }
            
        }
    }
}

