using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopicHubBE.Models
{
    public class Category
    {
        //Attributes
        [Key]
        public int CategoryID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }

    }
}
