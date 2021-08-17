#nullable enable
using CsvHelper.Configuration.Attributes;

namespace Read_CSV
{
    public class Persons
    {
        [Name("firstName")]
        public string FirstName { get; set; }
        [Name("lastName")]
        public string LastName { get; set; }
        [Name("email")]
        public string Email { get; set; }
        [Name("phoneNumber")]
        public string? PhoneNumber { get; set; }
    }
}
