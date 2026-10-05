using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CG_DES_FORM_HELP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CG_DES_FORM_HELPController : Controller
{
    private readonly ICG_DES_FORM_HELPService _service;

    public CG_DES_FORM_HELPController(ICG_DES_FORM_HELPService service
    )
    {
        _service = service;
    }

    // GET: CG_DES_FORM_HELP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Index.cshtml", result);
    }

    // GET: CG_DES_FORM_HELP/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Details.cshtml", result);
    }

    // GET: CG_DES_FORM_HELP/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Create.cshtml", new CreateCG_DES_FORM_HELPDto());
    }

    // POST: CG_DES_FORM_HELP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCG_DES_FORM_HELPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Create.cshtml", createDto);
    }

    // GET: CG_DES_FORM_HELP/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCG_DES_FORM_HELPDto
        {
            HLP_APPLN = result.HLP_APPLN,
            HLP_INDEX = result.HLP_INDEX,
            HLP_MODTAB_NAME = result.HLP_MODTAB_NAME,
            HLP_GENERATED = result.HLP_GENERATED,
            HLP_SEQ = result.HLP_SEQ,
            HLP_TEXT = result.HLP_TEXT,
            HLP_TYPE = result.HLP_TYPE,
        };
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Edit.cshtml", updateDto);
    }

    // POST: CG_DES_FORM_HELP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCG_DES_FORM_HELPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.HLP_APPLN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Edit.cshtml", updateDto);
    }

    // GET: CG_DES_FORM_HELP/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CG_DES_FORM_HELP/Delete.cshtml", result);
    }

    // POST: CG_DES_FORM_HELP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
