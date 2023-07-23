namespace WebAppMiddleware
{
    public interface IManagementCars
    {
        public IList<Car> GetCarName(string name);
        public IList<Car> GetCarEngine(string engine);
        public IList<Car> GetCarAge(int age);
        public string[] getVendors();
        public string[] getEngines();
        
        public int getMaxAge();
    }
}
