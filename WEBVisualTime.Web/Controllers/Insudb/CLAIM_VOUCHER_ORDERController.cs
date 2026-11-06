using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER_ORDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_VOUCHER_ORDERController : Controller
{
    private readonly ICLAIM_VOUCHER_ORDERService _service;
    private readonly ICLAIM_VOUCHERService _CLAIM_VOUCHERService;

    public CLAIM_VOUCHER_ORDERController(ICLAIM_VOUCHER_ORDERService service
        , ICLAIM_VOUCHERService CLAIM_VOUCHERService
    )
    {
        _service = service;
        _CLAIM_VOUCHERService = CLAIM_VOUCHERService;
    }

    // GET: CLAIM_VOUCHER_ORDER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLAIM_VOUCHER_ORDER/Index.cshtml");

    // GET: CLAIM_VOUCHER_ORDER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Details.cshtml", result);
    }

    // GET: CLAIM_VOUCHER_ORDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_VOUCHERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Create.cshtml", new CreateCLAIM_VOUCHER_ORDERDto());
    }

    // POST: CLAIM_VOUCHER_ORDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_VOUCHER_ORDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_VOUCHERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Create.cshtml", createDto);
    }

    // GET: CLAIM_VOUCHER_ORDER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_VOUCHER_ORDERDto
        {
            NCLAIM_VOUCHER = result.NCLAIM_VOUCHER,
            NORDER_NUM = result.NORDER_NUM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NBORDEREAUX_CL = result.NBORDEREAUX_CL,
            NSETTLEMENT_NUM = result.NSETTLEMENT_NUM,
        };
        await PopulateCLAIM_VOUCHERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_VOUCHER_ORDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_VOUCHER_ORDERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM_VOUCHER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_VOUCHERDropdownAsync();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_VOUCHER_ORDER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_VOUCHER_ORDER/Delete.cshtml", result);
    }

    // POST: CLAIM_VOUCHER_ORDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_VOUCHERDropdownAsync()
    {
        var items = await _CLAIM_VOUCHERService.GetAllAsync();
        ViewData["NCLAIM_VOUCHER"] = new SelectList(items, nameof(CLAIM_VOUCHERDto.NCLAIM_VOUCHER), "SCLINUMDOCU");
    }

}
