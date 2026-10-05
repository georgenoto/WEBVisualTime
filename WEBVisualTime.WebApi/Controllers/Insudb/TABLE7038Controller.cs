using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7038;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TABLE7038Controller : ControllerBase
{
    private readonly ITABLE7038Service _service;

    public TABLE7038Controller(ITABLE7038Service service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TABLE7038Dto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<TABLE7038Dto>> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<TABLE7038Dto>> Create([FromBody] CreateTABLE7038Dto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.NROOFTYPE }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateTABLE7038Dto updateDto)
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
