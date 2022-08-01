namespace BlazorAppPizza.Data
{
    public class PizzaMenu
    {
        public string ImageTitle { get; set; }

        public string PizzaName { get; set; }

        public string Toppings { get; set; }

        public float PizzaPrice { get; set; }


        public bool Cheese { get; set; }

        public bool Pepperoni { get; set; }

        public bool Mushrooms { get; set; }

        public bool Tuna { get; set; }

        public bool Pineapple { get; set; }

        public bool Ham { get; set; }

        public bool Beef { get; set; }

        public int Quantity { get; set; }

        public float FinalPrice { get; set; }
    }
}
