using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_PART_CONDITIONS;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MASSIVE_PART_CONDITIONSController : ControllerBase
{
    private readonly IMASSIVE_PART_CONDITIONSService _service;

    public MASSIVE_PART_CONDITIONSController(IMASSIVE_PART_CONDITIONSService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<WEBVisualTime.Servicios.Services.Common.PagedResult<MASSIVE_PART_CONDITIONSDto>>> GetAll(
        int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null, CancellationToken cancellationToken = default)
    {
        var result = await _service.GetListPageAsync(page, q, cancellationToken, pageSize);
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<MASSIVE_PART_CONDITIONSDto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<MASSIVE_PART_CONDITIONSDto>> Create([FromBody] CreateMASSIVE_PART_CONDITIONSDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = WEBVisualTime.Entidades.Common.RecordKeys.Encode("MASSIVE_PART_CONDITIONS", result) }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateMASSIVE_PART_CONDITIONSDto updateDto)
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
