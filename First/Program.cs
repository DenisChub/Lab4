namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            EventBus eventBus = new EventBus(TimeSpan.FromSeconds(1));

            eventBus.Register("Подія 1", new Action<EventData>(data =>
            {
                Console.WriteLine($"Подія {data.Name} спрацювала  {data.TimeStamp}");
            }));

            eventBus.Register("Подія 2", new Action<EventData>(data =>
            {
                Console.WriteLine($"Подія {data.Name} спрацювала  {data.TimeStamp}");
            }));

            int count = 0;
            while (count < 5)
            {
                eventBus.SendEvent("Подія 1", $"Дата події {count}");
                eventBus.SendEvent("Подія 2", $"Дата події {count}");
                count++;
                Thread.Sleep(600);
            }
        }
    }
}