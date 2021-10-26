using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DNP_Assignment1.Data.Services
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task UpdateAdultAsync(int id, Adult adult);
        
    }
}