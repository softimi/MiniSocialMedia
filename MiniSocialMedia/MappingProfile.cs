using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MiniSocialMedia
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();

            CreateMap<Post, PostDto>();

            CreateMap<Follow, FollowDto>();

            CreateMap<UserForCreationDto, User>();

            CreateMap<PostCreationDto, Post>();

            CreateMap<FollowCreationDto, Follow>();

            CreateMap<PostForUpdateDto, Post>().ReverseMap(); ;

            CreateMap<UserForUpdateDto, User>();
        }
    }
}
