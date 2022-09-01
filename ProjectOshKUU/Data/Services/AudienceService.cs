using Microsoft.EntityFrameworkCore;
using OshKUU.Models;
using ProjectOshKUU.Data.Base;
using ProjectOshKUU.Data.Services.AbstractServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOshKUU.Data.Services
{
    public class AudienceService : EntityBaseRepository<Audience>, IAudienceService
    {
        private readonly AppDbContext _context;
        public AudienceService(AppDbContext context) : base(context) {
            _context = context;
        }

        public async Task<IEnumerable<Audience>> GetByLangAsync(int floor, int building, string lang)
        {
            return await _context.Audience.Where(x => x.Lang == lang && x.Floor==floor && x.Building == building).ToListAsync();
        }

        public async Task<Audience> GetFirstOrDefaultAsync(int floor, int building, int number,string lang)
        {
            return await _context.Audience.Where(x => x.Floor == floor && x.Building == building && x.Number == number && x.Lang==lang).FirstOrDefaultAsync();
        }
    }
}
