using Grpc.Net.Client;
using RoutingGrpcService.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClientRoutePlanning
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new DrivingRouter.DrivingRouterClient(channel);

            var request = new RouteRequest
            {
                StreetAddress = "123 Main",
                City = "Somewhere",
                Zip = "12345"
            };

            var reply = await client.PlanRouteAsync(request);

            Console.WriteLine($"This is {reply.Miles} and should get you there at {reply.DrivingTime.ToDateTime()}");
            foreach(var step in reply.Steps)
            {
                Console.WriteLine($"\t{step}");
            }
        }
    }
}
