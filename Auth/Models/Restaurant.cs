namespace Auth.Models
{
    public class Restaurant:Endroit
    {
        public int Id { get; set; }
        public string TypeCuisine { get; set; }
        public DateTime Horaire { get; set; }

        public IList<Tables> Tables { get; set; }
    }
}
