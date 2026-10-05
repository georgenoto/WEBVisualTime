using Microsoft.AspNetCore.Mvc;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_COLLECTION;
using WEBVisualTime.Servicios.Insudb.Services;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BOOK_COLLECTIONController : ControllerBase
{
    private readonly IBOOK_COLLECTIONService _service;

    public BOOK_COLLECTIONController(IBOOK_COLLECTIONService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BOOK_COLLECTIONDto>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

[HttpGet("{id}")]
    public async Task<ActionResult<BOOK_COLLECTIONDto>> GetById(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<BOOK_COLLECTIONDto>> Create([FromBody] CreateBOOK_COLLECTIONDto createDto)
    {
        var result = await _service.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = result.SCERTYPE }, result);
    }

    [HttpPut("{{id}}")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateBOOK_COLLECTIONDto updateDto)
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
