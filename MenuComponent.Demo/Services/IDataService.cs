using MenuItem_Model = MenuComponent.Models.MenuItem;

namespace MenuComponent.Demo.Services
{
    public interface IDataService
    {
        public List<MenuItem_Model> GetVehicles();

        public List<MenuItem_Model> GetProducts();

        public List<MenuItem_Model> GetSupport();
    }
}