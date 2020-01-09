using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Group
    {
        public Guid GroupID { get; set; }

        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
    }
}
