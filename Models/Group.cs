using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Time { get; set; }
    }
}
