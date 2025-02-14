using Microsoft.AspNetCore.JsonPatch;
using SRM_86.Models;

namespace SRM_86.Repo
{
    public interface IBonds
    {
        public Task<List<Bond>> GetAllBonds();
        public Task<Bond> GetBondById(int id);
        public Task<Bond> GetBondByName(string name);
        public Task<int> AddNewBond(Bond bond);
        public Task<string> UpdateBondById(int id, Bond bond);

        public Task<string> DeleteBondById(int id);
        public Task<string> UpdateSpecificBond(int id, JsonPatchDocument patch);
    }
}
