using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Vektorel.GameCenter.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(32)]
        [Required]
        public string FullName { get; set; }
    }
}
