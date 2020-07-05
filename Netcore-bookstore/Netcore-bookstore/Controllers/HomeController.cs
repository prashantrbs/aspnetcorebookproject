using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Netcore_bookstore.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Shri ramakarunanandayanaha";
        }
    }
}
