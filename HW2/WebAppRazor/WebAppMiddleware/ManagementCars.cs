using System.Dynamic;

namespace WebAppRazor
{
    public class ManagementCars : IManagementCars
    {
        private int numberOfCarsToGenerate = 100;

        private IList<Car> carsList = new List<Car>();
        private List<string> Engines = new List<string> { "Petrol", "Diesel", "Mild hybrid", "Hybrid", "Gas" };
        private List<string> Vendors = new List<string> { "VW", "BMW", "Lexus", "Fiat", "Tesla", "Nissan", "Renault" };

        public ManagementCars() // generate some data to work with in middlewares
        {
            Random.Shared.Next(0, 50);

            for (int i = 0; i < numberOfCarsToGenerate; i++)
            {
                carsList.Add(new Car() {
                    Age    = Random.Shared.Next(0, 20),
                    Name   = Vendors[Random.Shared.Next(Vendors.Count)],
                    Engine = Engines[Random.Shared.Next(Engines.Count)],
                }
                );
            }
        }

		public IList<Car> SearchCar(Func<Car, bool> condition)
		{
			IList<Car> result = new List<Car>();

			foreach (Car car in carsList)
			{
				if (condition.Invoke(car))
                    result.Add(car);
			}
			return result;
		}

		public IList<Car> GetCarAge(int age)
        {
            return carsList.Where(x => x.Age == age).ToList();
        }

        public IList<Car> GetCarEngine(string engine)
        {
            return carsList.Where(x => x.Engine.ToLower() == engine.ToLower()).ToList();
        }

        public IList<Car> GetCarName(string name)
        {
            return carsList.Where(x => x.Name.ToLower() == name.ToLower()).ToList();
        }

		public List<string> getEngines()
        {
            return Engines;
        }

        public List<string> getVendors()
        {
            return Vendors;
        }

        public int getMaxAge()
        {
            return numberOfCarsToGenerate;
        }
	}
}
