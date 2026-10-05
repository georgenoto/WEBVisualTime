using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_TYPE_MATCH;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_TYPE_MATCHController : Controller
{
    private readonly ICDI_TYPE_MATCHService _service;

    public CDI_TYPE_MATCHController(ICDI_TYPE_MATCHService service
    )
    {
        _service = service;
    }

    // GET: CDI_TYPE_MATCH
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Index.cshtml", result);
    }

    // GET: CDI_TYPE_MATCH/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Details.cshtml", result);
    }

    // GET: CDI_TYPE_MATCH/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Create.cshtml", new CreateCDI_TYPE_MATCHDto());
    }

    // POST: CDI_TYPE_MATCH/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_TYPE_MATCHDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Create.cshtml", createDto);
    }

    // GET: CDI_TYPE_MATCH/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_TYPE_MATCHDto
        {
            TYPE_SHORT_NAME = result.TYPE_SHORT_NAME,
            EL_TYPE_OF = result.EL_TYPE_OF,
            EL_OCCUR_TYPE = result.EL_OCCUR_TYPE,
        };
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Edit.cshtml", updateDto);
    }

    // POST: CDI_TYPE_MATCH/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_TYPE_MATCHDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.TYPE_SHORT_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Edit.cshtml", updateDto);
    }

    // GET: CDI_TYPE_MATCH/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_TYPE_MATCH/Delete.cshtml", result);
    }

    // POST: CDI_TYPE_MATCH/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
