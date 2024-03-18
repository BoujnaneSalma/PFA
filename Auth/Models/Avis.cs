namespace Auth.Models
{
    public class Avis
    {
        public int Id { get; set; }
        public string Commentaire { get; set; }
        public DateTime Date { get; set; }

        public Client client { get; set; }
        public int ClientId; 
    }
}
