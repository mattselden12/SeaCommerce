using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeaCommerce.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SeaCommerce.Controllers
{
    public class HomeController : Controller
    {
        private SeaCommerceContext _context;
		public HomeController(SeaCommerceContext context)
		{
			_context = context;
		}

        [HttpGet("")]
        public IActionResult AdminLogin()
        {
            return View("AdminIndex");
        }

        [HttpGet("browse")]
        public IActionResult Browse()
        {
            List<Category> AllCategories = _context.categories.ToList();
            List<Player> AllPlayers = _context.players.ToList();
            return View("Browse", AllPlayers);
        }

        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View("Cart");
        }

        [HttpGet("info")]
        public IActionResult Info()
        {
            return View("Info");
        }

        [HttpGet("AdminOrders")]
        public IActionResult AdminOrders()
        {
            return View("AdminOrders");
        }

        [HttpGet("AdminOrderShow")]
        public IActionResult AdminOrderShow()
        {
            return View("AdminOrderShow");
        }

        [HttpGet("AdminProducts")]
        public IActionResult AdminProducts()
        {
            return View("AdminProducts");
        }

        [HttpGet("AdminProductAdd")]
        public IActionResult AdminProductAdd()
        {
            return View("AdminProductAdd");
        }

        [HttpGet("AdminProductEdit")]
        public IActionResult AdminProductEdit()
        {
            return View("AdminProductEdit");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
















namespace SeaCommerce
{
	public static class SessionExtensions
	{
		public static void SetObjectAsJson(this ISession session, string key, object value)
		{
			session.SetString(key, JsonConvert.SerializeObject(value));
		}
		public static T GetObjectFromJson<T>(this ISession session, string key)
		{
			string value = session.GetString(key);
			return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
		}
	}
}
