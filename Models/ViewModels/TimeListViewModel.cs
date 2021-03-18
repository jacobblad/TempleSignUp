﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models.ViewModels
{
    public class TimeListViewModel
    {
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<AvailableTime> AvailableTimes { get; }
    }
}
