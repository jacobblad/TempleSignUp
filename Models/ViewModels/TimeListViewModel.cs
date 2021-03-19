using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models.ViewModels
{
    //Enabling the 2 classes to be enumerable
    public class TimeListViewModel
    {
        public IEnumerable<AvailableTime> AvailableTimes { get; set; }
        public IEnumerable<Group> Groups { get; set; }
    }
}
