using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BILLS_HISController : Controller
{
    private readonly IBILLS_HISService _service;

    public BILLS_HISController(IBILLS_HISService service
    )
    {
        _service = service;
    }

    // GET: BILLS_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BILLS_HIS/Index.cshtml");

    // GET: BILLS_HIS/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS_HIS/Details.cshtml", result);
    }

    // GET: BILLS_HIS/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/BILLS_HIS/Create.cshtml", new CreateBILLS_HISDto());
    }

    // POST: BILLS_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBILLS_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BILLS_HIS/Create.cshtml", createDto);
    }

    // GET: BILLS_HIS/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBILLS_HISDto
        {
            SBILLTYPE = result.SBILLTYPE,
            NBILLNUM = result.NBILLNUM,
            DSTATDATE = result.DSTATDATE,
            NTRANSAC = result.NTRANSAC,
            NBILLMOVCODE = result.NBILLMOVCODE,
            STEXT = result.STEXT,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NBILLNUM_OLD = result.NBILLNUM_OLD,
            DSTATDATE_OLD = result.DSTATDATE_OLD,
            NUSER = result.NUSER,
            NUSER_OLD = result.NUSER_OLD,
            NIDTRANSACTION = result.NIDTRANSACTION,
            NIDTRANSACTION_OLD = result.NIDTRANSACTION_OLD,
            SBILLNUMSFE = result.SBILLNUMSFE,
            SBILLNUMSFE_OLD = result.SBILLNUMSFE_OLD,
            SNOTEDESCRIPTS = result.SNOTEDESCRIPTS,
        };
        return View("~/Views/Insudb/BILLS_HIS/Edit.cshtml", updateDto);
    }

    // POST: BILLS_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateBILLS_HISDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/BILLS_HIS/Edit.cshtml", updateDto);
    }

    // GET: BILLS_HIS/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS_HIS/Delete.cshtml", result);
    }

    // POST: BILLS_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
