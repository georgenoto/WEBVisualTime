using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CHARG_PREBASPAY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CHARG_PREBASPAYController : Controller
{
    private readonly ICHARG_PREBASPAYService _service;

    public CHARG_PREBASPAYController(ICHARG_PREBASPAYService service
    )
    {
        _service = service;
    }

    // GET: CHARG_PREBASPAY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CHARG_PREBASPAY/Index.cshtml", result);
    }

    // GET: CHARG_PREBASPAY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHARG_PREBASPAY/Details.cshtml", result);
    }

    // GET: CHARG_PREBASPAY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CHARG_PREBASPAY/Create.cshtml", new CreateCHARG_PREBASPAYDto());
    }

    // POST: CHARG_PREBASPAY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCHARG_PREBASPAYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CHARG_PREBASPAY/Create.cshtml", createDto);
    }

    // GET: CHARG_PREBASPAY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCHARG_PREBASPAYDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NAGE_INIT = result.NAGE_INIT,
            NMONTH_INI = result.NMONTH_INI,
            NOPTION = result.NOPTION,
            NAGE_END = result.NAGE_END,
            NMONTH_END = result.NMONTH_END,
            NTYPE_CHARG = result.NTYPE_CHARG,
            NRATE = result.NRATE,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NRATE_PPIN = result.NRATE_PPIN,
            NUSERCODE = result.NUSERCODE,
            SAPLYQUOT = result.SAPLYQUOT,
        };
        return View("~/Views/Insudb/CHARG_PREBASPAY/Edit.cshtml", updateDto);
    }

    // POST: CHARG_PREBASPAY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCHARG_PREBASPAYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CHARG_PREBASPAY/Edit.cshtml", updateDto);
    }

    // GET: CHARG_PREBASPAY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CHARG_PREBASPAY/Delete.cshtml", result);
    }

    // POST: CHARG_PREBASPAY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
