using System;
using System.Collections.Generic;

namespace Sistema_de_Reservas_de_Vehículos.Models;

public partial class Usuario//Esto no se va a usar porque por mi culpa cada que se crea una base de datos nuevas, con ella automaticamente se crean la tabla login y usuario, que no tienen que ver con este proyecto, esta configurado asi, tengo que cambiar eso.
{
    public string? Nombre { get; set; }

    public string? Clave { get; set; }

    public string Usuarios { get; set; } = null!;
}
