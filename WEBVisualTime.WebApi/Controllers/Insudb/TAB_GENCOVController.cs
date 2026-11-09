using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GENCOV;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TAB_GENCOVController : ControllerBase
{
    private readonly ITAB_GENCOVService _service;

    public TAB_GENCOVController(ITAB_GENCOVService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<WEBVisualTime.Servicios.Services.Common.PagedResult<TAB_GENCOVDto>>> GetAll(
        int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null, CancellationToken cancellationToken = default)
    {
        var result = await _service.GetListPageAsync(page, q, cancellationToken, pageSize);
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<TAB_GENCOVDto>> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<TAB_GENCOVDto>> Create([FromBody] CreateTAB_GENCOVDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.NCOVERGEN }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateTAB_GENCOVDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
