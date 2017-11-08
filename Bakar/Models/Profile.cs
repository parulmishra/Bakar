using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bakar.Models
{
    [Table("Profiles")]
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<User> Friends { get; set; }
        public virtual ICollection<User> RequestsSent { get; set; }
        public virtual ICollection<User> RequestsReceived { get; set;}
    }
}
