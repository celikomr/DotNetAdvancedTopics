using Grpc.Core;
using Grpc.Net.Client;
using GrpcServices.Protos;

using var channel = GrpcChannel.ForAddress("http://localhost:5141");
var client = new Sample.SampleClient(channel);

//var reply = await client.UnaryCallAsync(new SampleRequest { Message = "Sample Message" });
//Console.WriteLine("Response: " + reply.Message);


var reply = client.StreamingFromServer(new SampleRequest { Message = "Sample Message", Index = 5 });
while (await reply.ResponseStream.MoveNext())
{
    Console.WriteLine("Response: " + reply.ResponseStream.Current);
}



Console.WriteLine("Shutting down");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
