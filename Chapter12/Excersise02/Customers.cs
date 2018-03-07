using System.ComponentModel.DataAnnotations;

namespace Excersise02
{
    class Customer
    {
        public string CustomerID { get; set; }
        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(15)]
        public string City { get; set; }
    }
}
