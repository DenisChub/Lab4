namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Wolf wolf = new Wolf();
            Bear bear = new Bear();
            snake.ShowPoperties();
            wolf.ShowPoperties();
            bear.ShowPoperties();
        }
    }
}