using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAgenda.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
       

      

    }
}
