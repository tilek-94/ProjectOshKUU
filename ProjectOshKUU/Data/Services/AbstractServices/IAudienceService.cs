using OshKUU.Models;
using ProjectOshKUU.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOshKUU.Data.Services.AbstractServices
{
    public interface IAudienceService : IEntityBaseRepository<Audience>
    {
        Task<IEnumerable<Audience>> GetByLangAsync(int floor,int building,string lang);
        Task <Audience> GetFirstOrDefaultAsync(int floor,int building, int number, string lang);
    }
}
