using Grpc.Net.Client;
using GrpcServerProject;
using System;
using System.Threading.Tasks;

namespace GrpcClientProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Client Start.");

            var input = new HelloRequest { Name = "Khaled" };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.WriteLine("Client End.");

            Console.ReadLine();
        }
    }
}
