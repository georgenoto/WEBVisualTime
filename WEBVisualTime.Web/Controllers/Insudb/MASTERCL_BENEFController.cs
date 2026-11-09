using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_BENEF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERCL_BENEFController : Controller
{
    private readonly IMASTERCL_BENEFService _service;

    public MASTERCL_BENEFController(IMASTERCL_BENEFService service
    )
    {
        _service = service;
    }

    // GET: MASTERCL_BENEF
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MASTERCL_BENEF/Index.cshtml");

    // GET: MASTERCL_BENEF/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_BENEF/Details.cshtml", result);
    }

    // GET: MASTERCL_BENEF/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASTERCL_BENEF/Create.cshtml", new CreateMASTERCL_BENEFDto());
    }

    // POST: MASTERCL_BENEF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERCL_BENEFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTERCL_BENEF/Create.cshtml", createDto);
    }

    // GET: MASTERCL_BENEF/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERCL_BENEFDto
        {
            NMASTERORDER = result.NMASTERORDER,
            NCONSEC = result.NCONSEC,
            SCLIENT_BENEF = result.SCLIENT_BENEF,
            SCLIENT_REP = result.SCLIENT_REP,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NCLAIMBENEF_ID = result.NCLAIMBENEF_ID,
            NBENE_TYPE = result.NBENE_TYPE,
            NRELATION = result.NRELATION,
            NPARTICIP = result.NPARTICIP,
            NORDER_NUM = result.NORDER_NUM,
            SCLIENAME_BEN = result.SCLIENAME_BEN,
            NTYPCLIENTDOC_BEN = result.NTYPCLIENTDOC_BEN,
            SCLINUMDOCU_BEN = result.SCLINUMDOCU_BEN,
            SPHONE_BEN = result.SPHONE_BEN,
            SCELLPHONE_BEN = result.SCELLPHONE_BEN,
            SEMAIL_BEN = result.SEMAIL_BEN,
            SCLIENAME_REP = result.SCLIENAME_REP,
            NTYPCLIENTDOC_REP = result.NTYPCLIENTDOC_REP,
            SCLINUMDOCU_REP = result.SCLINUMDOCU_REP,
            SPHONE_REP = result.SPHONE_REP,
            SCELLPHONE_REP = result.SCELLPHONE_REP,
            SEMAIL_REP = result.SEMAIL_REP,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/MASTERCL_BENEF/Edit.cshtml", updateDto);
    }

    // POST: MASTERCL_BENEF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateMASTERCL_BENEFDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASTERCL_BENEF/Edit.cshtml", updateDto);
    }

    // GET: MASTERCL_BENEF/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_BENEF/Delete.cshtml", result);
    }

    // POST: MASTERCL_BENEF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
