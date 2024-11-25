using MenuItem_Model = MenuComponent.Models.MenuItem;

namespace MenuComponent.Demo.Services
{
    public class InMemoryDataService : IDataService
    {
        private readonly InMemoryData _data = new InMemoryData();

        public List<MenuItem_Model> GetProducts()
        {
            return _data.Products;
        }

        public List<MenuItem_Model> GetSupport()
        {
            return _data.SupportItems;
        }

        public List<MenuItem_Model> GetVehicles()
        {
            return _data.Vehicles;
        }
    }
}
