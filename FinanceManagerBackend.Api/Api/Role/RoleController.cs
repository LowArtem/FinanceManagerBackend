using AutoMapper;
using FinanceManagerBackend.Api.Api._Base;
using FinanceManagerBackend.Api.Attributes;
using FinanceManagerBackend.Api.Dto.Role;
using FinanceManagerBackend.Core.Dto;
using FinanceManagerBackend.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinanceManagerBackend.Api.Api.Role;

/// <summary>
/// Контроллер управления ролями
/// </summary>
[ApiController]
[ApiVersion("1.0")]
[SetRoute]
[Authorize]
public class RoleController : BaseCrudController<Core.Model.Auth.Role, RoleRequestDto, RoleResponseDto>
{
    /// <inheritdoc />
    public RoleController(IEfCoreRepository<Core.Model.Auth.Role> repository,
        ILogger<RoleController> logger, IMapper mapper) :
        base(repository, logger, mapper)
    {
    }
}