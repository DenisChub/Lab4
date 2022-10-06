namespace Second
{
    public abstract class Weapon
    {
        protected int damage;
        protected int durability;
        protected int price;

        public virtual int Damage()
        {
            return damage;
        }

        public virtual void Repair()
        {
            durability += 10;
        }

        public virtual int Sell()
        {
            return price;
        }

        public virtual void ShowMethods()
        {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}