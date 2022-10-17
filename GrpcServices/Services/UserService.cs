using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace GrpcServices.Services;

public class UserService : User.UserBase
{
    private readonly ILogger<UserService> _logger;

    public UserService(ILogger<UserService> logger)
    {
        _logger = logger;
    }

    public override Task<UserResponse> GetUsers(Empty request, ServerCallContext context)
    {
        return Task.FromResult(new UserResponse());
    }

    public override Task<UserResponse> GetUserById(UserRequest request, ServerCallContext context)
    {
        return Task.FromResult(new UserResponse());
    }
}
