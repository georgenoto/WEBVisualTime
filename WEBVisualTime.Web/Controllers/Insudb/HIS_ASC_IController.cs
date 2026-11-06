using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.HIS_ASC_I;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class HIS_ASC_IController : Controller
{
    private readonly IHIS_ASC_IService _service;
    private readonly IASCII_I_HEADService _ASCII_I_HEADService;
    private readonly ITABLE182Service _TABLE182Service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE293Service _TABLE293Service;
    private readonly ITABLE9Service _TABLE9Service;

    public HIS_ASC_IController(IHIS_ASC_IService service
        , IASCII_I_HEADService ASCII_I_HEADService
        , ITABLE182Service TABLE182Service
        , ITABLE7Service TABLE7Service
        , ITABLE293Service TABLE293Service
        , ITABLE9Service TABLE9Service
    )
    {
        _service = service;
        _ASCII_I_HEADService = ASCII_I_HEADService;
        _TABLE182Service = TABLE182Service;
        _TABLE7Service = TABLE7Service;
        _TABLE293Service = TABLE293Service;
        _TABLE9Service = TABLE9Service;
    }

    // GET: HIS_ASC_I
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/HIS_ASC_I/Index.cshtml");

    // GET: HIS_ASC_I/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HIS_ASC_I/Details.cshtml", result);
    }

    // GET: HIS_ASC_I/Create
    public async Task<IActionResult> Create()
    {
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/HIS_ASC_I/Create.cshtml", new CreateHIS_ASC_IDto());
    }

    // POST: HIS_ASC_I/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateHIS_ASC_IDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/HIS_ASC_I/Create.cshtml", createDto);
    }

    // GET: HIS_ASC_I/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateHIS_ASC_IDto
        {
            NID = result.NID,
            SASCII_NAME = result.SASCII_NAME,
            SPAY_FORM = result.SPAY_FORM,
            NBANK_CODE = result.NBANK_CODE,
            NCONCEPT = result.NCONCEPT,
            DSTAT_DATE = result.DSTAT_DATE,
            SACC_NUMBER = result.SACC_NUMBER,
            NAGENCY = result.NAGENCY,
            SCLIENT = result.SCLIENT,
            SACCOUNTHOLDER = result.SACCOUNTHOLDER,
            NREQUEST_NU = result.NREQUEST_NU,
            NAMOUNT = result.NAMOUNT,
            SDESCRIPT = result.SDESCRIPT,
            SBANKACCOUNT = result.SBANKACCOUNT,
            NBANKEXT = result.NBANKEXT,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/HIS_ASC_I/Edit.cshtml", updateDto);
    }

    // POST: HIS_ASC_I/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHIS_ASC_IDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateASCII_I_HEADDropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        return View("~/Views/Insudb/HIS_ASC_I/Edit.cshtml", updateDto);
    }

    // GET: HIS_ASC_I/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/HIS_ASC_I/Delete.cshtml", result);
    }

    // POST: HIS_ASC_I/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateASCII_I_HEADDropdownAsync()
    {
        var items = await _ASCII_I_HEADService.GetAllAsync();
        ViewData["SASCII_NAME"] = new SelectList(items, nameof(ASCII_I_HEADDto.SASCII_NAME), "SACC_NUMBER");
    }

    private async Task PopulateTABLE182DropdownAsync()
    {
        var items = await _TABLE182Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE182Dto.SPAY_FORM), "SDESCRIPT");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
        ViewData["NBANKEXT"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE293DropdownAsync()
    {
        var items = await _TABLE293Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE293Dto.NCONCEPT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

}
