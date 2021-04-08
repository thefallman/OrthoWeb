using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.Entities;

namespace com.orthofeet.Repositories.Interfaces
{
    public interface IReferenceRepository 
    {
        Task<ICollection<Facility>> GetFacilities();
    }
}