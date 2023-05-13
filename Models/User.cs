using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopicHubBE.Models
{
    public class User
    {
        //Attributes
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string HashPassword { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Avatar { get; set; }
        [DefaultValue(0)]
        public int RatingScore { get; set; }
        [DefaultValue(0)]
        [DataType(DataType.Currency)]
        public int InAppMoney { get; set; }
        public string? BankAccount { get; set; }

        //Relations
        //public virtual ICollection<Hub> Hubs { get; set;}
    }
}
