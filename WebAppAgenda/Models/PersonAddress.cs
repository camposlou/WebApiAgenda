using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAgenda.Models
{
    public class PersonAddress
    {
        public int Id { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        [ForeignKey("Address")]
        public int IdAddress { get; set; }
        public virtual Person Person { get; set; }
        public virtual Address Address { get; set; }
    }
}
