using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab1EfCodeFirst.Models
{
    public class LeaveForm
    {
        [Key]

        public int LeaveFormID { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public DateTime DateFrom{ get; set; }
        [Required]
        public DateTime DateTo{ get; set; }

        public DateTime DateOfRegister { get; set; }

        [Required]
        public virtual Employee Employee { get; set; } // Många till 1
    }
}
