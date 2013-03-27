using System.Collections.Generic;

namespace HighriseApi.Models
{
    public class Parties
    {
        public Parties()
        {
            People = new List<Person>();
            Companies = new List<Company>();
        }

        public List<Person> People { get; set; }
        public List<Company> Companies { get; set; }
    }
}
