using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? BookId { get; set; }
        //[ForeignKey("Book")]
        public virtual Book Book { get; set; }

        public int? CustomerId { get; set; }
        //[ForeignKey("Customer")]
        public virtual Customer Customer { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime ReturnDate { get; set; }

    }
}
