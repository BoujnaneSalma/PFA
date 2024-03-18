namespace Auth.Models
{
    public class Endroit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Langitude { get; set; }
        public int Latitude { get; set; }
       
        public Ville ville { get; set; }
        public int VilleId { get; set; }
    }
}
