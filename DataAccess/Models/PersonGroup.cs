using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class PersonGroup
    {
        public int Id { get; set; }
        public string GropName { get; set; }

        public List<Person> Person { get; set; }
    }
}
