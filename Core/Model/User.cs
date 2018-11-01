using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class User : DateTimeGeneric
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Messages = new HashSet<Message>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string SaltPassWord { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
