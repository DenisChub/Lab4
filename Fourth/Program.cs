namespace Fourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ApplicationLicense applicationLicense = new ApplicationLicense();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(applicationLicense.Status);
                Console.WriteLine("Введіть ліцензійний ключ - [trial/pro] *****");

                string[] message = Console.ReadLine().Split(" ");
                if (message.Length == 1)
                {
                    applicationLicense.AllowCommon();
                    continue;
                }

                Console.WriteLine("Ви перейшли на іншу версію");
                Console.ReadLine();
            }
        }
    }
}