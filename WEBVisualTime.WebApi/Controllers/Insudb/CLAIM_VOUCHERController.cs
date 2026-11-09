using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CLAIM_VOUCHERController : ControllerBase
{
    private readonly ICLAIM_VOUCHERService _service;

    public CLAIM_VOUCHERController(ICLAIM_VOUCHERService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<WEBVisualTime.Servicios.Services.Common.PagedResult<CLAIM_VOUCHERDto>>> GetAll(
        int page = 1, int pageSize = WEBVisualTime.Entidades.Common.ListingPolicy.DefaultPageSize, string? q = null, CancellationToken cancellationToken = default)
    {
        var result = await _service.GetListPageAsync(page, q, cancellationToken, pageSize);
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<CLAIM_VOUCHERDto>> GetById(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<CLAIM_VOUCHERDto>> Create([FromBody] CreateCLAIM_VOUCHERDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.NCLAIM_VOUCHER }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] UpdateCLAIM_VOUCHERDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
