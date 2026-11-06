using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.INQUIRY_AS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1014;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class INQUIRY_ASController : Controller
{
    private readonly IINQUIRY_ASService _service;
    private readonly ITABLE1014Service _TABLE1014Service;
    private readonly IWINDOWSService _WINDOWSService;

    public INQUIRY_ASController(IINQUIRY_ASService service
        , ITABLE1014Service TABLE1014Service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _TABLE1014Service = TABLE1014Service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: INQUIRY_AS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/INQUIRY_AS/Index.cshtml");

    // GET: INQUIRY_AS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INQUIRY_AS/Details.cshtml", result);
    }

    // GET: INQUIRY_AS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE1014DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/INQUIRY_AS/Create.cshtml", new CreateINQUIRY_ASDto());
    }

    // POST: INQUIRY_AS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateINQUIRY_ASDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE1014DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/INQUIRY_AS/Create.cshtml", createDto);
    }

    // GET: INQUIRY_AS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateINQUIRY_ASDto
        {
            NKEYNUM = result.NKEYNUM,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateTABLE1014DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/INQUIRY_AS/Edit.cshtml", updateDto);
    }

    // POST: INQUIRY_AS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateINQUIRY_ASDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NKEYNUM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE1014DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/INQUIRY_AS/Edit.cshtml", updateDto);
    }

    // GET: INQUIRY_AS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/INQUIRY_AS/Delete.cshtml", result);
    }

    // POST: INQUIRY_AS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE1014DropdownAsync()
    {
        var items = await _TABLE1014Service.GetAllAsync();
        ViewData["NKEYNUM"] = new SelectList(items, nameof(TABLE1014Dto.NKEYNUM), "SDESCRIPT");
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
