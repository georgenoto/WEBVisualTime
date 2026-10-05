using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY_BIND;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RM_LINK_CUSTOMIZED_QUERY_BINDController : Controller
{
    private readonly IRM_LINK_CUSTOMIZED_QUERY_BINDService _service;

    public RM_LINK_CUSTOMIZED_QUERY_BINDController(IRM_LINK_CUSTOMIZED_QUERY_BINDService service
    )
    {
        _service = service;
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY_BIND
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Index.cshtml", result);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY_BIND/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Details.cshtml", result);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY_BIND/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Create.cshtml", new CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto());
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY_BIND/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRM_LINK_CUSTOMIZED_QUERY_BINDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Create.cshtml", createDto);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY_BIND/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto
        {
            QUERY_NAME = result.QUERY_NAME,
            BIND_NAME = result.BIND_NAME,
            BIND_PROPERTY_NAME = result.BIND_PROPERTY_NAME,
            BIND_SEQUENCE = result.BIND_SEQUENCE,
        };
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Edit.cshtml", updateDto);
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY_BIND/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateRM_LINK_CUSTOMIZED_QUERY_BINDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.QUERY_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Edit.cshtml", updateDto);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY_BIND/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY_BIND/Delete.cshtml", result);
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY_BIND/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
