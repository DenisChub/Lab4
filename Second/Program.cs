namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var eventBus = new EventBus();
            var subscriber1 = new Subscriber(eventBus, 1);
            var subscriber2 = new Subscriber(eventBus, 2);
            var subscriber3 = new Subscriber(eventBus, 3);

            var publisher = new Publisher(eventBus);

            publisher.PublishEvent("Подія 1", 1, "Дата події 1");
            publisher.PublishEvent("Подія 2", 2, "Дата події 2");
            publisher.PublishEvent("Подія 3", 3, "Дата події 3");
        }
    }
}