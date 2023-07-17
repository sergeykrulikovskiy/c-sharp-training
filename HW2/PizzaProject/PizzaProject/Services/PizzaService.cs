namespace PizzaProject.Services
{
    using Interfaces;
    using PizzaProject.Models;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Xml.Linq;

    public class PizzaService : IPizzaService
    {
        // якщо хтось це буде дивитись :)
        // щоб не шукати якісь БД з паблік доступом, то використав статік змінну в якості бази.
        public static IList<Pizza> pizzaList = new List<Pizza>();

        public Pizza CreatePizza(Pizza pizza)
        {
            pizza.Id = pizza.GetID();
            
            AddPizzaToDB(pizza);
            
            return pizza;
        }

        public bool DeletePizza(string id)
        {
            bool pizzaFound = false;

            Pizza findPizza = GetPizza(id);
            
            if (findPizza != null) {
                pizzaList.Remove(findPizza);
                pizzaFound= true;
            } 
            return pizzaFound;
        }

        public Pizza GetPizza(string id)
        {
            Pizza? pizzaFound = null;
            foreach (Pizza pizza in pizzaList)
            {
                if (pizza.Id == id)
                {
                    pizzaFound = pizza;   
                    break;
                }
            }
            return pizzaFound; 
        }
        public IList<Pizza> GetAllPizza()
        {
            return pizzaList;
        }

        public bool UpdatePizza(Pizza pizza)
        {
            bool result = false;

            Pizza pizzaInDb = GetPizza(pizza.Id);

            if (pizzaInDb != null)
            {
                pizzaInDb.Size = pizza.Size;
                pizzaInDb.Name = pizza.Name;
                pizzaInDb.Price = pizza.Price;
                pizzaInDb.Toppings = pizza.Toppings;

                result = true;
            }
            return result;
        }

        public Pizza GeneratePizza()
        {
            Pizza pizza = new Pizza();
            IList<string> pizzaNames = new List<string> { "Veggie", "Pepperoni", "Margherita", "BBQ Chicken", "Hawaiian", "Neapolitan", "New York–style", "Meat Pizza" };
            IList<string> pizzaSizes = new List<string> { "Small", "Medium", "Big" };

            pizza.Id = pizza.GetID();
            pizza.Name = pizzaNames[Random.Shared.Next(pizzaNames.Count)];
            pizza.Size = pizzaSizes[Random.Shared.Next(pizzaSizes.Count)];

            Random rnd = new Random();
            pizza.Price = Convert.ToDouble((rnd.NextDouble() * 10).ToString("F2"));

            pizza.Toppings = Enumerable.Range(1, 3).Select(index => new Toppings()).ToArray();

            AddPizzaToDB(pizza);

            return pizza;
        }

        public bool AddPizzaToDB(Pizza pizza)
        {
            pizzaList.Add(pizza);
            return true;
        }
    }
}
