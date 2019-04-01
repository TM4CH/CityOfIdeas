using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Adress
    {
        [Key]
        public string Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
    }
}