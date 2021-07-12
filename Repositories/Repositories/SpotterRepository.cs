using Database.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class SpotterRepository : ISpotterRepository
    {
        private readonly EnvisDbContext _context;

        public SpotterRepository(EnvisDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewItem(Spotter objSpot)
        {
            if(_context != null)
            {
                await _context.Spotters.AddAsync(objSpot);
                await _context.SaveChangesAsync();

                return objSpot.Id;
            }
            return 0;
        }

        public async Task<int> DeleteItem(int id)
        {
            int result = 0;
            if (_context != null)
            {
                var item = await _context.Spotters.FirstOrDefaultAsync(x => x.Id == id);

                if (item != null)
                {
                    _context.Remove(item);
                    result = await _context.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }

        public async Task<List<Spotter>> GetAllItems()
        {
            if (_context != null) return await _context.Spotters.ToListAsync();

            return null;
        }

        public async Task<Spotter> GetIndividualItem(int id)
        {
            if (_context != null) return await _context.Spotters.FirstOrDefaultAsync(x => x.Id == id);

            return null;
        }

        public async Task UpdateItem(Spotter objSpot)
        {
            if(_context != null)
            {
                _context.Spotters.Update(objSpot);
                await _context.SaveChangesAsync();
            }
        }
    }
}
