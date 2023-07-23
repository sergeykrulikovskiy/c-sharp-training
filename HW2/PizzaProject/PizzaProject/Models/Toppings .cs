using Microsoft.Extensions.Options;

namespace PizzaProject
{
    public class Toppings
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Weight { get; set; }

        public Toppings()
        {
            IList<string> toppingNames = new List<string> { "Bacon", "Black olives", "Canadian bacon", "Chicken", "Green peppers", "Mushrooms", "Pepperoni", "Red onions", "Sausage", "Tomatoes" };
            
            Name  = toppingNames[Random.Shared.Next(toppingNames.Count)];

            Random rnd = new Random();
            Price = Convert.ToDouble((rnd.NextDouble() * 10).ToString("F2"));

            Weight = Random.Shared.Next(1,20);
        }
    }
}
