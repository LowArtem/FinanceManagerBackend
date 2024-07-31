using FinanceManagerBackend.Core.Dto;
using FinanceManagerBackend.Core.Model.Auth;
using AutoMapper;
using FinanceManagerBackend.Api.Dto.Role;
using FinanceManagerBackend.Api.Dto.User;
using FinanceManagerBackend.Core.Extensions;

namespace FinanceManagerBackend.Api.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, AuthResponseDto>()
            .ForMember(
                dest => dest.Roles,
                opt =>
                    opt.MapFrom(u => u.UserRoles.Select(r => r.Id)));

        CreateMap<UserRequestDto, User>()
            .ForMember(dest => dest.PasswordHash,
                opt => opt.MapFrom(x => x.Password.Hash()));

        CreateMap<User, UserResponseDto>();
        CreateMap<Role, RoleResponseDto>();
        CreateMap<RoleRequestDto, Role>();
    }
}