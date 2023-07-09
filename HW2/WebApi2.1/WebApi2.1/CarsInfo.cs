namespace WebApi2._1
{
    public class CarsInfo
    {
        private static readonly string[] Vendors = new[]
        {
        "BMW", "Audi", "ZAZ", "VW","Tesla","MadeInChina"
        };
        private static readonly string[] Types = new[]
        {
        "Sedan", "Sport Car", "Crossover", "Coupe", "Hatchback"
        };

        public string Vendor { get;}
        public string Type { get;}
        public int Mileage { get;}
        public int Age { get;}

        public CarsInfo()
        {
            Vendor = SetVendor();
            Type = SetType();
            Age = SetAge(); 
            Mileage = SetMileage();
        }
        public string SetVendor() {
            return Vendors[Random.Shared.Next(Vendors.Length)];
        }
        public string SetType()
        {
            return Types[Random.Shared.Next(Types.Length)];
        }

        public int SetMileage()
        {
            return Random.Shared.Next(0, 100500);
        }

        public int SetAge()
        {
            return Random.Shared.Next(0, 50);
        }
    }
}
