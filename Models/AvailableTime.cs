using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class AvailableTime
    {
        [Key]
        public int AvailableTimeId { get; set; }
        public DateTime TimeSlot { get; set; }
    }
}
