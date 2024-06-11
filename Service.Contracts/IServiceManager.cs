namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }

        IPostService PostService { get; }

        IFollowService FollowService { get; }
    }
}
