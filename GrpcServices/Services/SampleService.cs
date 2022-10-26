using Grpc.Core;

namespace GrpcServices.Services;

public class SampleService : Sample.SampleBase
{
    public override Task<SampleResponse> UnaryCall(SampleRequest request, ServerCallContext context)
    {
        Console.WriteLine(request.Message);
        var response = new SampleResponse() { Index = request.Index, Message = $"Message: '{request.Message}' received successfully" };
        return Task.FromResult(response);
    }

    public override async Task StreamingFromServer(SampleRequest request, IServerStreamWriter<SampleResponse> responseStream, ServerCallContext context)
    {
        for (var i = 0; i < request.Index; i++)
        {
            Console.WriteLine(i);
            await responseStream.WriteAsync(new SampleResponse() { Index = i });
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }

    public override async Task<SampleResponse> StreamingFromClient(IAsyncStreamReader<SampleRequest> requestStream, ServerCallContext context)
    {
        await foreach (var message in requestStream.ReadAllAsync())
        {
            Console.WriteLine(message);
        }
        return new SampleResponse();
    }

    public override async Task StreamingBothWays(IAsyncStreamReader<SampleRequest> requestStream, 
        IServerStreamWriter<SampleResponse> responseStream, ServerCallContext context)
    {
        await foreach (var message in requestStream.ReadAllAsync())
        {
            Console.WriteLine(message);
            await responseStream.WriteAsync(new SampleResponse());
        }
    }
}
