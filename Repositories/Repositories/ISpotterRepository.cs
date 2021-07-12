using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Database.Model;

namespace Repositories.Repositories
{
    public interface ISpotterRepository
    {
        Task<List<Spotter>> GetAllItems();
        Task<Spotter> GetIndividualItem(int id);
        Task<int> AddNewItem(Spotter objSpot);
        Task UpdateItem(Spotter objSpot);
        Task<int> DeleteItem(int id);
    }
}
