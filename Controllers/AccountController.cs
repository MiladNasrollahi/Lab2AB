
// I, Milad Nasrollahi, student number 000284021, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1B.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab1B.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(ApplicationDbContext context)
        {
            //_context = context;
        }
       /* public async Task<string> Seed()
        {
            int numberOfUsers = 0;
            if (_context.ApplicationUser.Count() == 0)
            {
                ApplicationUser user1 = new ApplicationUser { FirstName = "Joe", LastName = "Smith", UserName = "jSmith", Email = "jSmith@gmail.com", Company = "GMV", Position = "Dealer" };
                ApplicationUser user2 = new ApplicationUser { FirstName = "Sally", LastName = "Dun", UserName = "sDun", Email = "sDun@yahoo.com", Company = "GMV", Position = "Sales Associate" };
                _context.AddRange(user1, user2);
                await _context.SaveChangesAsync();
                numberOfUsers = 2;
            }
            return $"{numberOfUsers} cars added.";
        }
        turn View();
        } */
    }
}