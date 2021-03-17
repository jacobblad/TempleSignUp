using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleSignUp.Models
{
    public class EFTempleRepository : ITempleRepository
    {
        private TempleDbContext _context;

        public EFTempleRepository(TempleDbContext context)
        {
            _context = context;
        }
        public IQueryable<Group> Groups => _context.Groups;
        public IQueryable<AvailableTime> AvailableTimes => _context.AvailableTimes;
    }
}
