using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_ADDITIONALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLORDER_ADDITIONALSController : Controller
{
    private readonly ICLORDER_ADDITIONALSService _service;
    private readonly ICLAIM_ORDERService _CLAIM_ORDERService;

    public CLORDER_ADDITIONALSController(ICLORDER_ADDITIONALSService service
        , ICLAIM_ORDERService CLAIM_ORDERService
    )
    {
        _service = service;
        _CLAIM_ORDERService = CLAIM_ORDERService;
    }

    // GET: CLORDER_ADDITIONALS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLORDER_ADDITIONALS/Index.cshtml");

    // GET: CLORDER_ADDITIONALS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Details.cshtml", result);
    }

    // GET: CLORDER_ADDITIONALS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_ORDERDropdownAsync();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Create.cshtml", new CreateCLORDER_ADDITIONALSDto());
    }

    // POST: CLORDER_ADDITIONALS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLORDER_ADDITIONALSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Create.cshtml", createDto);
    }

    // GET: CLORDER_ADDITIONALS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLORDER_ADDITIONALSDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NORDER_NUM = result.NORDER_NUM,
            NADDITIONAL_ORDER = result.NADDITIONAL_ORDER,
            SMEDICATION = result.SMEDICATION,
            NQUANTITYOFMEDICATION = result.NQUANTITYOFMEDICATION,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCLAIM_ORDERDropdownAsync();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Edit.cshtml", updateDto);
    }

    // POST: CLORDER_ADDITIONALS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLORDER_ADDITIONALSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Edit.cshtml", updateDto);
    }

    // GET: CLORDER_ADDITIONALS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_ADDITIONALS/Delete.cshtml", result);
    }

    // POST: CLORDER_ADDITIONALS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIM_ORDERDropdownAsync()
    {
        var items = await _CLAIM_ORDERService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCLAIM), "STYPECARE");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NCASE_NUM), "STYPECARE");
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(CLAIM_ORDERDto.NDEMAN_TYPE), "STYPECARE");
        ViewData["NORDER_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NORDER_NUM), "STYPECARE");
    }

}
