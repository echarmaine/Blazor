namespace BlazorAppPizza.Data
{
    public class PizzaMenuList
    {
        public static List<PizzaMenu> PizzaList = new List<PizzaMenu>()
        {
            new PizzaMenu() {ImageTitle = "Bolognese", PizzaName = "Bolognese"},
            new PizzaMenu() {ImageTitle = "Carbonara", PizzaName = "Carbonara"},
            new PizzaMenu() {ImageTitle = "Hawaiian", PizzaName = "Hawaiian"},
            new PizzaMenu() {ImageTitle = "Margerita", PizzaName = "Margerita"},
            new PizzaMenu() {ImageTitle = "MeatFeast", PizzaName = "MeatFeast"},
            new PizzaMenu() {ImageTitle = "Mushroom", PizzaName = "Mushroom"},
            new PizzaMenu() {ImageTitle = "Pepperoni", PizzaName = "Pepperoni"},
            new PizzaMenu() {ImageTitle = "Seafood", PizzaName = "Seafood"},
            new PizzaMenu() {ImageTitle = "Vegetarian", PizzaName = "Vegetarian"},
            new PizzaMenu() {ImageTitle = "Customized", PizzaName = "Customized"},
        };


        public static Task<List<PizzaMenu>> GetPizzaList()
        {
            return Task.FromResult(PizzaList);
        }
    }
}
