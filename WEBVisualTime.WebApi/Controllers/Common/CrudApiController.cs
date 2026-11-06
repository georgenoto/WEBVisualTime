using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.WebApi.Controllers.Common;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudApiController<TDto, TCreateDto, TUpdateDto, TKey> : ControllerBase
    where TDto : class where TCreateDto : class where TUpdateDto : class
{
    private readonly IService<TDto, TCreateDto, TUpdateDto, TKey> service;
    private readonly Func<TDto, TKey> key;
    protected CrudApiController(IService<TDto, TCreateDto, TUpdateDto, TKey> service, Func<TDto, TKey> key)
    {
        this.service = service;
        this.key = key;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TDto>>> GetAll() => Ok(await service.GetAllAsync());
    [HttpGet("{id}")]
    public async Task<ActionResult<TDto>> GetById([FromRoute] TKey id)
    {
        var dto = await service.GetByIdAsync(id);
        return dto is null ? NotFound() : Ok(dto);
    }
    [HttpPost]
    public async Task<ActionResult<TDto>> Create([FromBody] TCreateDto dto)
    {
        var result = await service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = key(result) }, result);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] TKey id, [FromBody] TUpdateDto dto)
        => await service.UpdateAsync(id, dto) ? NoContent() : NotFound();
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] TKey id)
        => await service.DeleteAsync(id) ? NoContent() : NotFound();
}
