namespace Auth.Models
{
    public class Hotel:Endroit
    {
        public int Id { get; set; }
        public int NbrEtoile { get; set; }
        public int NbrCHambre { get; set; }
       
        public IList<Chambres> Chambres { get; set; }
    }
}
