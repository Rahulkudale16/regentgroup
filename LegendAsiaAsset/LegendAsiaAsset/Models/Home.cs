namespace LegendAsiaAsset.Models
{
    public class Home
    {
        public UserDetails UserDetails { get; set; }
        public LocationModel LocationModel { get; set; }
        public ITAssetDetailsModel ITAssetDetailsModel{ get; set; }
        public InfrastructureModel InfrastructureModel{ get; set; }
        public List<int> LaptopList { get; set; }   
        public List<int> DeskTopList { get; set; }   

        public Home() { 
        
            DeskTopList = new List<int>();
            LaptopList = new List<int>();
            UserDetails = new UserDetails();
            LocationModel = new LocationModel();
            ITAssetDetailsModel  = new ITAssetDetailsModel();
            InfrastructureModel = new InfrastructureModel();
        }
    }
}
