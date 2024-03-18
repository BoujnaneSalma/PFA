namespace Auth.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public int Password { get; set; }

        public IList<Avis> Avis { get; set; }
        public IList<Reservation> Reservations { get; set; }
    }
}
