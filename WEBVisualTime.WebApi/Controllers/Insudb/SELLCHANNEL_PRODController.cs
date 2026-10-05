using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.SELLCHANNEL_PROD;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SELLCHANNEL_PRODController : ControllerBase
{
    private readonly ISELLCHANNEL_PRODService _service;

    public SELLCHANNEL_PRODController(ISELLCHANNEL_PRODService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SELLCHANNEL_PRODDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<SELLCHANNEL_PRODDto>> GetById(DateTime id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<SELLCHANNEL_PRODDto>> Create([FromBody] CreateSELLCHANNEL_PRODDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.DEFFECDATE }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(DateTime id, [FromBody] UpdateSELLCHANNEL_PRODDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{{id}}")]
    public async Task<IActionResult> Delete(DateTime id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
