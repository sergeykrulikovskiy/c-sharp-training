using System.Dynamic;

namespace PizzaProject.Models
{
    public class Pizza
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public IList<Toppings> Toppings { get; set; }

        public string GetID()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}
