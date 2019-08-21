using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabTest.API.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(63)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(63)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(63)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }
    }
}
