using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema_de_Reservas_de_Vehículos.Models;

public class ReservationsController : Controller
{
    private readonly VehicleReservationsDbContext _context;

    public ReservationsController(VehicleReservationsDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var reservations = _context.Reservations
            .Select(r => new ReservationViewModel{
                Id = r.Id,
                UserName = r.User.Name,
                Vehicle = r.Vehicle.Model,
                StartDate = r.StartDate,
                EndDate = r.EndDate,
                TotalPrice = r.TotalPrice
            }).ToList();

        return View(reservations);
    }

    public IActionResult Create()
    {
        ViewBag.Users = new SelectList(_context.Users, "Id", "Name");
        ViewBag.Vehicles = new SelectList(_context.Vehicles, "Id", "Model");

        return View();
    }

    [HttpPost]
    public IActionResult Create(Reservation reservation)
    {
        Console.WriteLine("POST ejecutado");
        ModelState.Remove("User");
        ModelState.Remove("Vehicle");
        ModelState.Remove("Status");

        var overlapping = _context.Reservations.Any(r =>
            r.VehicleId == reservation.VehicleId &&
            reservation.StartDate < r.EndDate &&
            reservation.EndDate > r.StartDate
        );

        if (overlapping)
        {
            ModelState.AddModelError("", "Vehículo ya reservado en esas fechas");
        }

        var days = (reservation.EndDate - reservation.StartDate).Days;
        if (days <= 0) days = 1;

        if (ModelState.IsValid)
        {
            var vehicle = _context.Vehicles.Find(reservation.VehicleId);

            reservation.TotalPrice = days * vehicle.PricePerDay;
            reservation.Status = "Activa";

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            Console.WriteLine("Guardado");

            return RedirectToAction("Index");
        }

        ViewBag.Users = new SelectList(_context.Users, "Id", "Name");
        ViewBag.Vehicles = new SelectList(_context.Vehicles, "Id", "Model");

        return View(reservation);
    }
}