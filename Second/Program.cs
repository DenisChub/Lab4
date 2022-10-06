namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage(new Pistol(), new Rifle(), new Shotgun());
            storage.ShowTree();
        }
    }
}
