using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Services.Common;
using WEBVisualTime.Datos;

namespace WEBVisualTime.WebApi.Controllers.Common;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudApiController<TDto, TCreateDto, TUpdateDto, TKey> : ControllerBase
    where TDto : class where TCreateDto : class where TUpdateDto : class
{
    private readonly IService<TDto, TCreateDto, TUpdateDto, TKey> service;
    private readonly Func<TDto, TKey> key;
    private string? ReadOnlyReason => ModelIntegrityRules.ReadOnlyReason(typeof(TDto).Name[..^3]);
    private ConflictObjectResult ReadOnlyResult() => Conflict(new ProblemDetails
    {
        Status = 409, Title = "Catálogo de solo lectura", Detail = ReadOnlyReason
    });
    protected CrudApiController(IService<TDto, TCreateDto, TUpdateDto, TKey> service, Func<TDto, TKey> key)
    {
        this.service = service;
        this.key = key;
    }
    [HttpGet]
    public async Task<ActionResult<PagedResult<TDto>>> GetAll(int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null,
        CancellationToken cancellationToken = default)
        => Ok(await service.GetListPageAsync(page, q, cancellationToken, pageSize));
    [HttpGet("{id}")]
    public async Task<ActionResult<TDto>> GetById([FromRoute] TKey id)
    {
        if (ReadOnlyReason is not null) return ReadOnlyResult();
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Ok(dto);
    }
    [HttpPost]
    public async Task<ActionResult<TDto>> Create([FromBody] TCreateDto dto)
    {
        if (ReadOnlyReason is not null) return ReadOnlyResult();
        var result = await service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = key(result) }, result);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] TKey id, [FromBody] TUpdateDto dto)
    {
        if (ReadOnlyReason is not null) return ReadOnlyResult();
        return await service.UpdateAsync(id, dto) ? NoContent() : NotFound();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] TKey id)
    {
        if (ReadOnlyReason is not null) return ReadOnlyResult();
        return await service.DeleteAsync(id) ? NoContent() : NotFound();
    }
}
