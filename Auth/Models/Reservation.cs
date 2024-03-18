namespace Auth.Models
{
    public class Reservation
    {
        public int Id{ get; set; }
        public DateTime Date { get; set; }
        public string Etat { get; set; }

        public Client client { get; set; }
        public int  ClientId { get; set; }
        
    
        public IList<Paiment> paiments { get; set; }
    
        public IList<Chambres> chambres { get; set; }

        public IList<Tables> tables { get; set; }


    }
}
