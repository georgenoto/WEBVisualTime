using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_BKP_256518;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PREMIUM_BKP_256518Controller : Controller
{
    private readonly IPREMIUM_BKP_256518Service _service;

    public PREMIUM_BKP_256518Controller(IPREMIUM_BKP_256518Service service
    )
    {
        _service = service;
    }

    // GET: PREMIUM_BKP_256518
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Index.cshtml", result);
    }

    // GET: PREMIUM_BKP_256518/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Details.cshtml", result);
    }

    // GET: PREMIUM_BKP_256518/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Create.cshtml", new CreatePREMIUM_BKP_256518Dto());
    }

    // POST: PREMIUM_BKP_256518/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePREMIUM_BKP_256518Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Create.cshtml", createDto);
    }

    // GET: PREMIUM_BKP_256518/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePREMIUM_BKP_256518Dto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NRECEIPT = result.NRECEIPT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NPERIOD_OLD = result.NPERIOD_OLD,
            NPERIOD_NEW = result.NPERIOD_NEW,
            DFIX = result.DFIX,
        };
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Edit.cshtml", updateDto);
    }

    // POST: PREMIUM_BKP_256518/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePREMIUM_BKP_256518Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Edit.cshtml", updateDto);
    }

    // GET: PREMIUM_BKP_256518/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_BKP_256518/Delete.cshtml", result);
    }

    // POST: PREMIUM_BKP_256518/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
