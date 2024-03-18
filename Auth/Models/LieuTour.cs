namespace Auth.Models
{
    public class LieuTour:Endroit
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Horaire { get; set; }
    }
}
