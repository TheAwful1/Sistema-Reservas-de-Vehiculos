using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Reservas_de_Vehículos.Data
{
    public class AppDbContext:DbContext
    {
        //Acuerdate de poner 
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

    }
}
