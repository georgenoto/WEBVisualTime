using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.SIGNSCAPOFF;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SIGNSCAPOFFController : ControllerBase
{
    private readonly ISIGNSCAPOFFService _service;

    public SIGNSCAPOFFController(ISIGNSCAPOFFService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SIGNSCAPOFFDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<SIGNSCAPOFFDto>> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<SIGNSCAPOFFDto>> Create([FromBody] CreateSIGNSCAPOFFDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.NBRANCH }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateSIGNSCAPOFFDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{{id}}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
