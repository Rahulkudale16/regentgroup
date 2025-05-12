using LegendAsiaAsset.Models;

namespace LegendAsiaAsset.Contracts
{
    public interface ISQLTablesRepository
    {
        public Task<string> GetDBType();
    }
}
