using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bakar.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public virtual int PostId { get; set; }
        public virtual User User { get; set; }
        public DateTime CommentDate { get; set; }
        public string Description { get; set; }
    }
}
