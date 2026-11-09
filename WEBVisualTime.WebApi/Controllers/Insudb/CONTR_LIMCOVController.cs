using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTR_LIMCOV;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CONTR_LIMCOVController : ControllerBase
{
    private readonly ICONTR_LIMCOVService _service;

    public CONTR_LIMCOVController(ICONTR_LIMCOVService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<WEBVisualTime.Servicios.Services.Common.PagedResult<CONTR_LIMCOVDto>>> GetAll(
        int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null, CancellationToken cancellationToken = default)
    {
        var result = await _service.GetListPageAsync(page, q, cancellationToken, pageSize);
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<CONTR_LIMCOVDto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<CONTR_LIMCOVDto>> Create([FromBody] CreateCONTR_LIMCOVDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = WEBVisualTime.Entidades.Common.RecordKeys.Encode("CONTR_LIMCOV", result) }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateCONTR_LIMCOVDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
