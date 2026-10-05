using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.COVER_QUOTA;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class COVER_QUOTAController : ControllerBase
{
    private readonly ICOVER_QUOTAService _service;

    public COVER_QUOTAController(ICOVER_QUOTAService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<COVER_QUOTADto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<COVER_QUOTADto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<COVER_QUOTADto>> Create([FromBody] CreateCOVER_QUOTADto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.SCERTYPE }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateCOVER_QUOTADto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{{id}}")]
    public async Task<IActionResult> Delete(string id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
