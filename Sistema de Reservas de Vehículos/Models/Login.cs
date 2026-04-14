using System;
using System.Collections.Generic;

namespace Sistema_de_Reservas_de_Vehículos.Models;

public partial class Login
{
    public int? Ip { get; set; }

    public string? Usuarios { get; set; }

    public DateOnly? FechaLogins { get; set; }

    public virtual Usuario? UsuariosNavigation { get; set; }
}
