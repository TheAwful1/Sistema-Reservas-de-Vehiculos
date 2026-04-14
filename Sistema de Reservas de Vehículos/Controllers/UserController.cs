using Microsoft.AspNetCore.Mvc;
using Sistema_de_Reservas_de_Vehículos.Models;

namespace Sistema_de_Reservas_de_Vehículos.Controllers
{
    public class UserController : Controller
    {
        private readonly VehicleReservationsDbContext _context;

        public UserController(VehicleReservationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}
