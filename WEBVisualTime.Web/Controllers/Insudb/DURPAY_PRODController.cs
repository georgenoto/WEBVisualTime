using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DURPAY_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DURPAY_PRODController : Controller
{
    private readonly IDURPAY_PRODService _service;
    private readonly ITABLE5589Service _TABLE5589Service;

    public DURPAY_PRODController(IDURPAY_PRODService service
        , ITABLE5589Service TABLE5589Service
    )
    {
        _service = service;
        _TABLE5589Service = TABLE5589Service;
    }

    // GET: DURPAY_PROD
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DURPAY_PROD/Index.cshtml");

    // GET: DURPAY_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DURPAY_PROD/Details.cshtml", result);
    }

    // GET: DURPAY_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURPAY_PROD/Create.cshtml", new CreateDURPAY_PRODDto());
    }

    // POST: DURPAY_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDURPAY_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURPAY_PROD/Create.cshtml", createDto);
    }

    // GET: DURPAY_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDURPAY_PRODDto
        {
            NID = result.NID,
            DEFFECDATE = result.DEFFECDATE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NIDURAFIX = result.NIDURAFIX,
            NPDURAFIX = result.NPDURAFIX,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NTYPDURINS = result.NTYPDURINS,
            NTYPDURPAY = result.NTYPDURPAY,
        };
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURPAY_PROD/Edit.cshtml", updateDto);
    }

    // POST: DURPAY_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDURPAY_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURPAY_PROD/Edit.cshtml", updateDto);
    }

    // GET: DURPAY_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DURPAY_PROD/Delete.cshtml", result);
    }

    // POST: DURPAY_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
        ViewData["NTYPDURPAY"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

}
