using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_INTERFACE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_ERR_INTERFACEController : Controller
{
    private readonly IT_ERR_INTERFACEService _service;

    public T_ERR_INTERFACEController(IT_ERR_INTERFACEService service
    )
    {
        _service = service;
    }

    // GET: T_ERR_INTERFACE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/T_ERR_INTERFACE/Index.cshtml");

    // GET: T_ERR_INTERFACE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_ERR_INTERFACE/Details.cshtml", result);
    }

    // GET: T_ERR_INTERFACE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/T_ERR_INTERFACE/Create.cshtml", new CreateT_ERR_INTERFACEDto());
    }

    // POST: T_ERR_INTERFACE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_ERR_INTERFACEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_ERR_INTERFACE/Create.cshtml", createDto);
    }

    // GET: T_ERR_INTERFACE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_ERR_INTERFACEDto
        {
            SKEY = result.SKEY,
            NSEQ = result.NSEQ,
            NROW = result.NROW,
            NERROR = result.NERROR,
            SDESCRIPT = result.SDESCRIPT,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            NCLAIM = result.NCLAIM,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/T_ERR_INTERFACE/Edit.cshtml", updateDto);
    }

    // POST: T_ERR_INTERFACE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_ERR_INTERFACEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_ERR_INTERFACE/Edit.cshtml", updateDto);
    }

    // GET: T_ERR_INTERFACE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_ERR_INTERFACE/Delete.cshtml", result);
    }

    // POST: T_ERR_INTERFACE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
