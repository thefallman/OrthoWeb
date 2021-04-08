using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.Repositories
{
    public class ReferenceRepository: X3SageRepository, IReferenceRepository
    {
        public ReferenceRepository(X3SageDbContext context) : base(context)
        {
        }

        public async Task<ICollection<Facility>> GetFacilities()
        {
            return await Context.Facilities.ToListAsync();
        }
    }
}