using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY_BIND;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RM_LINK_CUSTOMIZED_QUERY_BINDController : ControllerBase
{
    private readonly IRM_LINK_CUSTOMIZED_QUERY_BINDService _service;

    public RM_LINK_CUSTOMIZED_QUERY_BINDController(IRM_LINK_CUSTOMIZED_QUERY_BINDService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RM_LINK_CUSTOMIZED_QUERY_BINDDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<RM_LINK_CUSTOMIZED_QUERY_BINDDto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<RM_LINK_CUSTOMIZED_QUERY_BINDDto>> Create([FromBody] CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.QUERY_NAME }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto updateDto)
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
