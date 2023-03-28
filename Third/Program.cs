namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var eventBus = new EventBus(new RetryPolicy(5, new TimeSpan(0, 0, 1), new TimeSpan(0, 0, 5)));
            var subscriber1 = new Subscriber("Подія", eventBus);

            var publisher = new Publisher(eventBus);

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    publisher.PublishEvent("Подія", new CustomEventArgs() { Name = "Опублікувана" });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не вдалося обробити подію: {ex.Message}");
                }
            }

            Console.ReadLine();
        }
    }
}