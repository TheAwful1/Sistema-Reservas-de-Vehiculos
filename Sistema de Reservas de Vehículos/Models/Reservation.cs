using System;
using System.Collections.Generic;

namespace Sistema_de_Reservas_de_Vehículos.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int VehicleId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
