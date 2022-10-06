namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Real Real = new Real();
            Real.Show(123, "Приклад", DateTime.Now);
        }
    }
}