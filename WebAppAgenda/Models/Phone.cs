using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppAgenda.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Landline{ get; set; }
        public string Mobile { get; set; }

        [ForeignKey("Person")]
        public int IdPerson { get; set; }

    }
}
