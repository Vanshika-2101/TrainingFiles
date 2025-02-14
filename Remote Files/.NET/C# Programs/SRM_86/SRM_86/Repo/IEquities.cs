using Microsoft.AspNetCore.JsonPatch;
using SRM_86.Models;

namespace SRM_86.Repo
{
    public interface IEquities
    {
        public Task<List<Equity>> GetAllEquities();
        public Task<Equity> GetEquityById(int id);
        public Task<Equity> GetEquityByName(string name);
        public Task<int> AddNewEquity(Equity equity);
        public Task<string> UpdateEquityById(int id, Equity equity);

        public Task<string> DeleteEquityById(int id);
        public Task<string> UpdateSpecificEquity(int id, JsonPatchDocument patch);
    }
}
