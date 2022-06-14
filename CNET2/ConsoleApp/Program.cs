using Data;
using Model;
using System.Linq;

Console.WriteLine("Hello, World!");

Client client1 = new Client() { Name = "Petr" };
Client client2 = new Client() { Name = "Alena" };
VIPClient client3 = new VIPClient() { Name = "Monika", Status = "GOLD" };

List<IGreetable> clients = new List<IGreetable>();
clients.Add(client1);
clients.Add(client2);
clients.Add(client3);

GreetClient(clients);

static void GreetClient(List<IGreetable> clients)
{
    foreach (var client in clients)
    {
        Console.WriteLine(client.SayHello());
    }
}

