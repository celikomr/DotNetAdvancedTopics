using Grpc.Core;

namespace GrpcServices.Services;

public class SampleService : Sample.SampleBase
{
    public override Task<SampleResponse> UnaryCall(SampleRequest request, ServerCallContext context)
    {
        var response = new SampleResponse() { Index = 1 };
        return Task.FromResult(response);
    }

    public override async Task StreamingFromServer(SampleRequest request, IServerStreamWriter<SampleResponse> responseStream, ServerCallContext context)
    {
        for (var i = 0; i < 5; i++)
        {
            await responseStream.WriteAsync(new SampleResponse());
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
            await responseStream.WriteAsync(new SampleResponse());
        }
    }
}
