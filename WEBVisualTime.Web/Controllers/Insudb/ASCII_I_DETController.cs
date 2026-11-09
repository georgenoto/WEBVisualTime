using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_DET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9229;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ASCII_I_DETController : Controller
{
    private readonly IASCII_I_DETService _service;
    private readonly IASCII_I_HEADService _ASCII_I_HEADService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE9229Service _TABLE9229Service;

    public ASCII_I_DETController(IASCII_I_DETService service
        , IASCII_I_HEADService ASCII_I_HEADService
        , ICLIENTService CLIENTService
        , ITABLE7Service TABLE7Service
        , ITABLE9Service TABLE9Service
        , ITABLE9229Service TABLE9229Service
    )
    {
        _service = service;
        _ASCII_I_HEADService = ASCII_I_HEADService;
        _CLIENTService = CLIENTService;
        _TABLE7Service = TABLE7Service;
        _TABLE9Service = TABLE9Service;
        _TABLE9229Service = TABLE9229Service;
    }

    // GET: ASCII_I_DET
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ASCII_I_DET/Index.cshtml");

    // GET: ASCII_I_DET/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ASCII_I_DET/Details.cshtml", result);
    }

    // GET: ASCII_I_DET/Create
    public async Task<IActionResult> Create()
    {
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9229DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_DET/Create.cshtml", new CreateASCII_I_DETDto());
    }

    // POST: ASCII_I_DET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateASCII_I_DETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9229DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_DET/Create.cshtml", createDto);
    }

    // GET: ASCII_I_DET/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateASCII_I_DETDto
        {
            SASCII_NAME = result.SASCII_NAME,
            NID = result.NID,
            SCLIENT = result.SCLIENT,
            SCLIENAME = result.SCLIENAME,
            NREQUEST_NEW = result.NREQUEST_NEW,
            NAMOUNT = result.NAMOUNT,
            SDESCRIPT = result.SDESCRIPT,
            SBANKACCOUNT = result.SBANKACCOUNT,
            NBANKEXT = result.NBANKEXT,
            NOFF_DEST_ID = result.NOFF_DEST_ID,
            NPAY_ID = result.NPAY_ID,
            DDATE_PAY = result.DDATE_PAY,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9229DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_DET/Edit.cshtml", updateDto);
    }

    // POST: ASCII_I_DET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateASCII_I_DETDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9229DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_DET/Edit.cshtml", updateDto);
    }

    // GET: ASCII_I_DET/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ASCII_I_DET/Delete.cshtml", result);
    }

    // POST: ASCII_I_DET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateASCII_I_HEADDropdownAsync()
    {
        var items = await _ASCII_I_HEADService.GetAllAsync();
        ViewData["SASCII_NAME"] = new SelectList(items, nameof(ASCII_I_HEADDto.SASCII_NAME), "SACC_NUMBER");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFF_DEST_ID"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9229DropdownAsync()
    {
        var items = await _TABLE9229Service.GetAllAsync();
        ViewData["NPAY_ID"] = new SelectList(items, nameof(TABLE9229Dto.NPAY_ID), "SDESCRIPT");
    }

}
