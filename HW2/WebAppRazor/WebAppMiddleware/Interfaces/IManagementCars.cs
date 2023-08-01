namespace WebAppRazor
{
    public interface IManagementCars
    {
        public IList<Car> GetCarName(string name);
		public IList<Car> GetCarEngine(string engine);
        public IList<Car> GetCarAge(int age);
        public List<string> getVendors();
        public List<string> getEngines();
        
        public int getMaxAge();

        public IList<Car> SearchCar(Func<Car, bool> condition);
    }
}
