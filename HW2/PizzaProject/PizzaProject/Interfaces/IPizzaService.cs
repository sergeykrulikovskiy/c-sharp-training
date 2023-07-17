namespace PizzaProject.Interfaces
{
    using Models;

    public interface IPizzaService
    {
        Pizza CreatePizza(Pizza pizza);
        
        Pizza GetPizza(string id);
        
        IList<Pizza> GetAllPizza();

        bool UpdatePizza(Pizza pizza);

        bool DeletePizza(string id);

        Pizza GeneratePizza();

        bool AddPizzaToDB(Pizza pizza);
    }
}
