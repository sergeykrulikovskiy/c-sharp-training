using System.Dynamic;

namespace WebAppMiddleware
{
    public class ManagementCars : IManagementCars
    {
        private int numberOfCarsToGenerate = 20;

        private IList<Car> carsList = new List<Car>();
        private string[] Engines = new[] { "Petrol", "Diesel", "Mild hybrid", "Hybrid", "Gas" };
        private string[] Vendors = new[] { "VW", "BMW", "Lexus", "Fiat", "Tesla", "Nissan", "Renault" };

        public ManagementCars() // generate some data to work with in middlewares
        {
            Random.Shared.Next(0, 50);

            for (int i = 0; i < numberOfCarsToGenerate; i++)
            {
                carsList.Add(new Car() {
                    Age = Random.Shared.Next(0, 20),
                    Name = Vendors[Random.Shared.Next(Vendors.Length)],
                    Engine = Engines[Random.Shared.Next(Engines.Length)],
                }
                );
            }
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

        public string[] getEngines()
        {
            return Engines;
        }

        public string[] getVendors()
        {
            return Vendors;
        }

        public int getMaxAge()
        {
            return numberOfCarsToGenerate;
        }
    }
}
