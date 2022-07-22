namespace Telepass
{
    using TelepassBackend;

    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Centralina centralina = new Centralina(database);

            TelepassBackend.Telepass telepass = new Telepass(2);
            centralina.Run(telepass);

            TelepassBackend.Telepass telepass2 = new Telepass(6);
            centralina.Run(telepass2);
        }
    }
}
