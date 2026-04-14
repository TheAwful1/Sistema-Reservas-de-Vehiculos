using System;
using System.Collections.Generic;

namespace Sistema_de_Reservas_de_Vehículos.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Plate { get; set; } = null!;

    public decimal PricePerDay { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
