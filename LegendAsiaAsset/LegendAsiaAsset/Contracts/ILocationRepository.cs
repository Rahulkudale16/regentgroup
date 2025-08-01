﻿using LegendAsiaAsset.Models;

namespace LegendAsiaAsset.Contracts
{
    public interface ILocationRepository
    {
        public Task<List<LocationModel>> GetLocationList(LocationModel locationModel);
        public Task<List<LocationModel>> GetRegionFromLocation();
        public Task<List<LocationModel>> GetCountryFromLocation();
        public Task<List<LocationModel>> GetLocationFromLocation(string Region);
        public Task<List<LocationModel>> GetLocationFromLocation1();
        public Task<List<LocationModel>> GetLocationFinal();
        public Task<ResponseModel> SaveLocation(LocationModel locationModel);
        public Task<ResponseModel> UpdateLocation(LocationModel locationModel);
        public Task<List<string>> GetCoutriesData(string regionName);
        public Task<List<string>> GetLocationData(string countryName);
        public Task<List<LocationModel>> GetLocationID(string Region, string Country, string Location1);
        public Task<bool> GetStatusLoc(LocationModel locationModel);
        public Task <string> GetLocationID(string Location);
    }
}
