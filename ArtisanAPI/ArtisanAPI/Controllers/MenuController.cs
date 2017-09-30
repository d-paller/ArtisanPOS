using ArtisanAPI.Context;
using ArtisanAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtisanAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private readonly MenuContext _context;

        public MenuController(MenuContext context)
        {
            _context = context;

            // If there are no items in the list (db)
            if (!_context.MenuItems.Any())
            {
                _context.MenuItems.Add(new MenuItem { Name = "item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<IEnumerable<MenuItem>> GetAll()
        {
            return await _context.MenuItems.ToListAsync();
        }
    }
}