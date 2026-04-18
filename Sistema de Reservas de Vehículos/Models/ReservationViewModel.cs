namespace Sistema_de_Reservas_de_Vehículos.Models
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Vehicle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
