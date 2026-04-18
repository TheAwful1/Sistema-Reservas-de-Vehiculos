using Microsoft.AspNetCore.Mvc;
using Sistema_de_Reservas_de_Vehículos.Models;

public class VehicleController : Controller
{
    private readonly VehicleReservationsDbContext _context;

    public VehicleController(VehicleReservationsDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var vehicles = _context.Vehicles.ToList();
        return View(vehicles);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Vehicle vehicle)
    {
        if (ModelState.IsValid)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(vehicle);
    }

    // GET: Edit
    public IActionResult Edit(int id)
    {
        var vehicle = _context.Vehicles.Find(id);
        if (vehicle == null) return NotFound();

        return View(vehicle);
    }


    // POST: Edit
    [HttpPost]
    public IActionResult Edit(Vehicle vehicle)
    {
        if (ModelState.IsValid)
        {
            _context.Vehicles.Update(vehicle);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        return View(vehicle);
    }

    // GET: Delete
    public IActionResult Delete(int id)
    {
        var vehicle = _context.Vehicles.Find(id);
        if (vehicle == null) return NotFound();

        return View(vehicle);
    }

    // POST: Delete
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var vehicle = _context.Vehicles.Find(id);
        if (vehicle != null)
        {
            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();
        }

        return RedirectToAction("Index");
    }

}