using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5602;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TABLE5602Controller : ControllerBase
{
    private readonly ITABLE5602Service _service;

    public TABLE5602Controller(ITABLE5602Service service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TABLE5602Dto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<TABLE5602Dto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<TABLE5602Dto>> Create([FromBody] CreateTABLE5602Dto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.STYPETAX }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateTABLE5602Dto updateDto)
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
