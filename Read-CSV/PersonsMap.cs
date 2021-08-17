using CsvHelper.Configuration;

namespace Read_CSV
{
    sealed class PersonsMap:ClassMap<Persons>
    {
        public PersonsMap()
        {
            Map(m => m.FirstName).Name("firstName");
            Map(m => m.LastName).Name("lastName");
            Map(m => m.Email).Name("email");
            Map(m => m.PhoneNumber).Name("phoneNumber");
        }
    }
}
