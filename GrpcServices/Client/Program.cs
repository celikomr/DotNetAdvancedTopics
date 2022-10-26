using Grpc.Core;
using Grpc.Net.Client;
using GrpcServices.Protos;

using var channel = GrpcChannel.ForAddress("http://localhost:5141");
var client = new Sample.SampleClient(channel);

//var reply = await client.UnaryCallAsync(new SampleRequest { Message = "Sample Message" });
//Console.WriteLine("Response: " + reply.Message);


//var reply = client.StreamingFromServer(new SampleRequest { Message = "Sample Message", Index = 5 });
//while (await reply.ResponseStream.MoveNext())
//{
//    Console.WriteLine("Response: " + reply.ResponseStream.Current);
//}


var reply = client.StreamingFromClient();
for (int i = 0; i < 5; i++)
{
    await reply.RequestStream.WriteAsync(new SampleRequest() { Index = i });
}
await reply.RequestStream.CompleteAsync();

Console.WriteLine("Shutting down");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
