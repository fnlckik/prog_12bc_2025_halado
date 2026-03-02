namespace PizzaTime
{
    public class Pizza
    {
        public string type;
        public bool isFamily;
        public int amount;

        public Pizza(string type, bool isFamily, int amount)
        {
            this.type = type;
            this.isFamily = isFamily;
            this.amount = amount;
        }

        public int Cost
        {
            get
            {
                double cost;
                switch (type)
                {
                    case "Songoku":
                        cost = 3500;
                        break;
                    case "Magyaros":
                        cost = 3800;
                        break;
                    case "Négysajtos":
                        cost = 4500;
                        break;
                    default:
                        cost = 0;
                        break;
                }
                if (isFamily) cost *= 1.25;
                return (int)cost * amount;
            }
        }

        public override string ToString()
        {
            string size = isFamily ? "45 cm" : "35 cm";
            return $"{amount} X {type} ({size}) - {Cost} Ft";
        }
    }
}
