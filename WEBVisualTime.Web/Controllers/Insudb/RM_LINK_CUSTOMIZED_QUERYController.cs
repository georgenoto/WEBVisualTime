using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.RM_LINK_CUSTOMIZED_QUERY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class RM_LINK_CUSTOMIZED_QUERYController : Controller
{
    private readonly IRM_LINK_CUSTOMIZED_QUERYService _service;

    public RM_LINK_CUSTOMIZED_QUERYController(IRM_LINK_CUSTOMIZED_QUERYService service
    )
    {
        _service = service;
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Index.cshtml", result);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Details.cshtml", result);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Create.cshtml", new CreateRM_LINK_CUSTOMIZED_QUERYDto());
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateRM_LINK_CUSTOMIZED_QUERYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Create.cshtml", createDto);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateRM_LINK_CUSTOMIZED_QUERYDto
        {
            QUERY_NAME = result.QUERY_NAME,
            QUERY_TEXT = result.QUERY_TEXT,
            ALIAS = result.ALIAS,
            NUMBER_OF_PROPERTIES = result.NUMBER_OF_PROPERTIES,
            FOLDER_CONTEXT = result.FOLDER_CONTEXT,
            OBJECT_CONTEXT = result.OBJECT_CONTEXT,
        };
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Edit.cshtml", updateDto);
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateRM_LINK_CUSTOMIZED_QUERYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.QUERY_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Edit.cshtml", updateDto);
    }

    // GET: RM_LINK_CUSTOMIZED_QUERY/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/RM_LINK_CUSTOMIZED_QUERY/Delete.cshtml", result);
    }

    // POST: RM_LINK_CUSTOMIZED_QUERY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
