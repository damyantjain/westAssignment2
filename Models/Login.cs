using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Login
    {
        
        public Guid LoginID { get; set; }

        [MaxLength(20)]
        [Required]
        public string uname { get; set; }
        [Required]
        public string psw { get; set; }

    }
}
