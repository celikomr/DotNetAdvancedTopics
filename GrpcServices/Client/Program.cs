using Grpc.Net.Client;
using GrpcServices.Protos;

using var channel = GrpcChannel.ForAddress("http://localhost:5141");
var client = new Sample.SampleClient(channel);

var reply = await client.UnaryCallAsync(new SampleRequest { Message = "Sample Message" });
Console.WriteLine("Response: " + reply.Message);

Console.WriteLine("Shutting down");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
