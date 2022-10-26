using Grpc.Core;

namespace GrpcServices.Services;

public class SampleService : Sample.SampleBase
{
    public override async Task StreamingFromServer(SampleRequest request, IServerStreamWriter<SampleResponse> responseStream, ServerCallContext context)
    {
        for (var i = 0; i < 5; i++)
        {
            await responseStream.WriteAsync(new SampleResponse());
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
