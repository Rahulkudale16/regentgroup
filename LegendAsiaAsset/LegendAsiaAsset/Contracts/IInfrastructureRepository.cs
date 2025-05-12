using Dapper;
using DocumentFormat.OpenXml.InkML;
using LegendAsiaAsset.Models;
using System.Data;

namespace LegendAsiaAsset.Contracts
{
    public interface IInfrastructureRepository
    {
        public Task<List<InfrastructureModel>> GetInfrastructureList(InfrastructureModel infrastructureModel);

        public Task<List<InfrastructureModel>> GetSerialnumberDropdownList();

        public Task<List<InfrastructureModel>> GetModelDropdownList();

        public Task<List<InfrastructureModel>> GetBrandDropdownList();

        public Task<List<InfrastructureModel>> GetAssetTypeDropdownList();

        public Task<LocationModel> GetLocationfromID(int IDLocation);

        public Task<ResponseModel> SaveInfrastructure(InfrastructureModel infrastructureModel);

        public Task<bool> UpdateInfrastructure(InfrastructureModel infrastructureModel);

        public Task<int> GetInfraCount(int id);

        public Task<bool> GetStatusInfra(InfrastructureModel infrastructureModel);

        public Task<ResponseModel> TransferInfraDetails(InfrastructureModel infrastructureModel);
        public Task<bool> TransferedAndDeletedInfra(InfrastructureModel infrastructureModel);
        public Task<bool> DeleteInfra(int IDInfra);
    }
}
