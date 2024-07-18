using Microsoft.AspNetCore.Mvc;
using DragonTravelRental.Models;
using System.Collections.Generic;

namespace DragonTravelRental.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            var services = new List<Service>
            {
                new Service { Name = "豪華明星保母車", Icon = "car", Description = "享受舒適豪華的旅程" },
                new Service { Name = "機場接送", Icon = "plane", Description = "安全準時的接送服務" },
                new Service { Name = "專屬司機", Icon = "user-tie", Description = "專業可靠的駕駛體驗" },
                new Service { Name = "賓士九人座", Icon = "car-side", Description = "寬敞舒適的群體出行選擇" },
                new Service { Name = "包車旅遊", Icon = "route", Description = "量身定制的旅遊行程" },
                new Service { Name = "全台服務", Icon = "map-marked-alt", Description = "提供全台灣的專業服務" }
            };

            return View(services);
        }
    }
}