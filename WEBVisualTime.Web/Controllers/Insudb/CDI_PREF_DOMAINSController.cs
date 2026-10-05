using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PREF_DOMAINS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CDI_PREF_DOMAINSController : Controller
{
    private readonly ICDI_PREF_DOMAINSService _service;

    public CDI_PREF_DOMAINSController(ICDI_PREF_DOMAINSService service
    )
    {
        _service = service;
    }

    // GET: CDI_PREF_DOMAINS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Index.cshtml", result);
    }

    // GET: CDI_PREF_DOMAINS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Details.cshtml", result);
    }

    // GET: CDI_PREF_DOMAINS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Create.cshtml", new CreateCDI_PREF_DOMAINSDto());
    }

    // POST: CDI_PREF_DOMAINS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCDI_PREF_DOMAINSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Create.cshtml", createDto);
    }

    // GET: CDI_PREF_DOMAINS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCDI_PREF_DOMAINSDto
        {
            PD_DOMAIN = result.PD_DOMAIN,
            PD_DESC = result.PD_DESC,
        };
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Edit.cshtml", updateDto);
    }

    // POST: CDI_PREF_DOMAINS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCDI_PREF_DOMAINSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.PD_DOMAIN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Edit.cshtml", updateDto);
    }

    // GET: CDI_PREF_DOMAINS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CDI_PREF_DOMAINS/Delete.cshtml", result);
    }

    // POST: CDI_PREF_DOMAINS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
