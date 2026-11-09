using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BILLS_NUM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BILLS_NUMController : Controller
{
    private readonly IBILLS_NUMService _service;
    private readonly ITABLE5001Service _TABLE5001Service;

    public BILLS_NUMController(IBILLS_NUMService service
        , ITABLE5001Service TABLE5001Service
    )
    {
        _service = service;
        _TABLE5001Service = TABLE5001Service;
    }

    // GET: BILLS_NUM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BILLS_NUM/Index.cshtml");

    // GET: BILLS_NUM/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS_NUM/Details.cshtml", result);
    }

    // GET: BILLS_NUM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/BILLS_NUM/Create.cshtml", new CreateBILLS_NUMDto());
    }

    // POST: BILLS_NUM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBILLS_NUMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/BILLS_NUM/Create.cshtml", createDto);
    }

    // GET: BILLS_NUM/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBILLS_NUMDto
        {
            NINSUR_AREA = result.NINSUR_AREA,
            SBILLTYPE = result.SBILLTYPE,
            NINITNUMB = result.NINITNUMB,
            NENDNUMB = result.NENDNUMB,
            NLASTBILL = result.NLASTBILL,
            DLASTCLOSED = result.DLASTCLOSED,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/BILLS_NUM/Edit.cshtml", updateDto);
    }

    // POST: BILLS_NUM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateBILLS_NUMDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5001DropdownAsync();
        return View("~/Views/Insudb/BILLS_NUM/Edit.cshtml", updateDto);
    }

    // GET: BILLS_NUM/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BILLS_NUM/Delete.cshtml", result);
    }

    // POST: BILLS_NUM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

}
