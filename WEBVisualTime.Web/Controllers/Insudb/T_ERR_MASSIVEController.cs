using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.T_ERR_MASSIVE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class T_ERR_MASSIVEController : Controller
{
    private readonly IT_ERR_MASSIVEService _service;

    public T_ERR_MASSIVEController(IT_ERR_MASSIVEService service
    )
    {
        _service = service;
    }

    // GET: T_ERR_MASSIVE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/T_ERR_MASSIVE/Index.cshtml", result);
    }

    // GET: T_ERR_MASSIVE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_ERR_MASSIVE/Details.cshtml", result);
    }

    // GET: T_ERR_MASSIVE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/T_ERR_MASSIVE/Create.cshtml", new CreateT_ERR_MASSIVEDto());
    }

    // POST: T_ERR_MASSIVE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateT_ERR_MASSIVEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_ERR_MASSIVE/Create.cshtml", createDto);
    }

    // GET: T_ERR_MASSIVE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateT_ERR_MASSIVEDto
        {
            SKEY = result.SKEY,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NERROR = result.NERROR,
            SDESCRIPT = result.SDESCRIPT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            SCERTYPE = result.SCERTYPE,
            SCLIENT = result.SCLIENT,
            NSEQ = result.NSEQ,
            STYPE = result.STYPE,
        };
        return View("~/Views/Insudb/T_ERR_MASSIVE/Edit.cshtml", updateDto);
    }

    // POST: T_ERR_MASSIVE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateT_ERR_MASSIVEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/T_ERR_MASSIVE/Edit.cshtml", updateDto);
    }

    // GET: T_ERR_MASSIVE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/T_ERR_MASSIVE/Delete.cshtml", result);
    }

    // POST: T_ERR_MASSIVE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
