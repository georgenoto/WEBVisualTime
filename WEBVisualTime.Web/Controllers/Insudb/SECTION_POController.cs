using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SECTION_PO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SECTION_POController : Controller
{
    private readonly ISECTION_POService _service;
    private readonly IWINDOWSService _WINDOWSService;
    private readonly ITABLE5588Service _TABLE5588Service;
    private readonly ITABLE5580Service _TABLE5580Service;

    public SECTION_POController(ISECTION_POService service
        , IWINDOWSService WINDOWSService
        , ITABLE5588Service TABLE5588Service
        , ITABLE5580Service TABLE5580Service
    )
    {
        _service = service;
        _WINDOWSService = WINDOWSService;
        _TABLE5588Service = TABLE5588Service;
        _TABLE5580Service = TABLE5580Service;
    }

    // GET: SECTION_PO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/SECTION_PO/Index.cshtml");

    // GET: SECTION_PO/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECTION_PO/Details.cshtml", result);
    }

    // GET: SECTION_PO/Create
    public async Task<IActionResult> Create()
    {
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE5588DropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        return View("~/Views/Insudb/SECTION_PO/Create.cshtml", new CreateSECTION_PODto());
    }

    // POST: SECTION_PO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSECTION_PODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE5588DropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        return View("~/Views/Insudb/SECTION_PO/Create.cshtml", createDto);
    }

    // GET: SECTION_PO/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSECTION_PODto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SPOLITYPE = result.SPOLITYPE,
            SCOMPON = result.SCOMPON,
            SCODISPL = result.SCODISPL,
            NTRATYPEP = result.NTRATYPEP,
            NSEQUENCE = result.NSEQUENCE,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NID = result.NID,
            NORIGIN = result.NORIGIN,
            NTYPE_AMEND = result.NTYPE_AMEND,
            DNULLDATE = result.DNULLDATE,
            SREPORT = result.SREPORT,
            NORDER = result.NORDER,
            SROUTINE = result.SROUTINE,
            SDESCRIPT = result.SDESCRIPT,
        };
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE5588DropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        return View("~/Views/Insudb/SECTION_PO/Edit.cshtml", updateDto);
    }

    // POST: SECTION_PO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSECTION_PODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateWINDOWSDropdownAsync();
        await PopulateTABLE5588DropdownAsync();
        await PopulateTABLE5580DropdownAsync();
        return View("~/Views/Insudb/SECTION_PO/Edit.cshtml", updateDto);
    }

    // GET: SECTION_PO/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SECTION_PO/Delete.cshtml", result);
    }

    // POST: SECTION_PO/Delete/{id}
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

    private async Task PopulateTABLE5588DropdownAsync()
    {
        var items = await _TABLE5588Service.GetAllAsync();
        ViewData["NTRATYPEP"] = new SelectList(items, nameof(TABLE5588Dto.NTRATYPEP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5580DropdownAsync()
    {
        var items = await _TABLE5580Service.GetAllAsync();
        ViewData["NORIGIN"] = new SelectList(items, nameof(TABLE5580Dto.NORIGIN), "SDESCRIPT");
    }

}
