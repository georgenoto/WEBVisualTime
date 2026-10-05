using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class COMMPAYREQ_ORDERSController : ControllerBase
{
    private readonly ICOMMPAYREQ_ORDERSService _service;

    public COMMPAYREQ_ORDERSController(ICOMMPAYREQ_ORDERSService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<COMMPAYREQ_ORDERSDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<COMMPAYREQ_ORDERSDto>> GetById(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<COMMPAYREQ_ORDERSDto>> Create([FromBody] CreateCOMMPAYREQ_ORDERSDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.NID_COMMPAYREQ }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(long id, [FromBody] UpdateCOMMPAYREQ_ORDERSDto updateDto)
    {
        var success = await _service.UpdateAsync(id, updateDto);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{{id}}")]
    public async Task<IActionResult> Delete(long id)
    {
        var success = await _service.DeleteAsync(id);
        if (!success) return NotFound();
        return NoContent();
    }
}
