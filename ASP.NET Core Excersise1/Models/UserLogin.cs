using FormFactory.Attributes;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = FormFactory.Attributes.RequiredAttribute;
using StringLengthAttribute = FormFactory.Attributes.StringLengthAttribute;

namespace ASP.NET_Core_Excersise1.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [Password]
        public string Password { get; set; }
    }
}
