using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPESUBTYPE_RELATIONSHIP;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TYPESUBTYPE_RELATIONSHIPController : ControllerBase
{
    private readonly ITYPESUBTYPE_RELATIONSHIPService _service;

    public TYPESUBTYPE_RELATIONSHIPController(ITYPESUBTYPE_RELATIONSHIPService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<WEBVisualTime.Servicios.Services.Common.PagedResult<TYPESUBTYPE_RELATIONSHIPDto>>> GetAll(
        int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null, CancellationToken cancellationToken = default)
    {
        var result = await _service.GetListPageAsync(page, q, cancellationToken, pageSize);
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<TYPESUBTYPE_RELATIONSHIPDto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<TYPESUBTYPE_RELATIONSHIPDto>> Create([FromBody] CreateTYPESUBTYPE_RELATIONSHIPDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = WEBVisualTime.Entidades.Common.RecordKeys.Encode("TYPESUBTYPE_RELATIONSHIP", result) }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateTYPESUBTYPE_RELATIONSHIPDto updateDto)
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
