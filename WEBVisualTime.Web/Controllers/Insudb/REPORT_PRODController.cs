using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REPORT_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REPORT_PRODController : Controller
{
    private readonly IREPORT_PRODService _service;
    private readonly IWINDOWSService _WINDOWSService;

    public REPORT_PRODController(IREPORT_PRODService service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: REPORT_PROD
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REPORT_PROD/Index.cshtml");

    // GET: REPORT_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORT_PROD/Details.cshtml", result);
    }

    // GET: REPORT_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/REPORT_PROD/Create.cshtml", new CreateREPORT_PRODDto());
    }

    // POST: REPORT_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREPORT_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/REPORT_PROD/Create.cshtml", createDto);
    }

    // GET: REPORT_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREPORT_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            SCODISPL = result.SCODISPL,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NREPTYPE = result.NREPTYPE,
            NTRATYPEP = result.NTRATYPEP,
            SREPORT = result.SREPORT,
        };
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/REPORT_PROD/Edit.cshtml", updateDto);
    }

    // POST: REPORT_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREPORT_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/REPORT_PROD/Edit.cshtml", updateDto);
    }

    // GET: REPORT_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REPORT_PROD/Delete.cshtml", result);
    }

    // POST: REPORT_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
