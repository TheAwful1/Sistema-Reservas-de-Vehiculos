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
            return View(users);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                using (_context)
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(user);
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            return View(user);
        }
        

        // POST: Edit
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }


        // GET: Delete
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            return View(user);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
