using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bakar.Models
{
    [Table("Posts")]
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int PostId { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }    
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
