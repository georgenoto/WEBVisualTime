using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.SDD_NLS_GLOBAL_NAME_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SDD_NLS_GLOBAL_NAME_DOMAINSController : ControllerBase
{
    private readonly ISDD_NLS_GLOBAL_NAME_DOMAINSService _service;

    public SDD_NLS_GLOBAL_NAME_DOMAINSController(ISDD_NLS_GLOBAL_NAME_DOMAINSService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SDD_NLS_GLOBAL_NAME_DOMAINSDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<SDD_NLS_GLOBAL_NAME_DOMAINSDto>> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<SDD_NLS_GLOBAL_NAME_DOMAINSDto>> Create([FromBody] CreateSDD_NLS_GLOBAL_NAME_DOMAINSDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.IRID }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateSDD_NLS_GLOBAL_NAME_DOMAINSDto updateDto)
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
