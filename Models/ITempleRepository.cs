using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public interface ITempleRepository
    {
        IQueryable<Group> Groups { get; }
        IQueryable<AvailableTime> AvailableTimes { get; }
    }
}
