namespace WebApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public required string City { get; set; }
        public required int Age { get; set; }
    }
}
