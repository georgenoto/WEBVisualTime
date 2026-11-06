using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9243;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERCL_HISController : Controller
{
    private readonly IMASTERCL_HISService _service;
    private readonly ITABLE9264Service _TABLE9264Service;
    private readonly ITABLE9237Service _TABLE9237Service;
    private readonly ITABLE9242Service _TABLE9242Service;
    private readonly ITABLE8604Service _TABLE8604Service;
    private readonly ITABLE9243Service _TABLE9243Service;
    private readonly ITABLE9212Service _TABLE9212Service;

    public MASTERCL_HISController(IMASTERCL_HISService service
        , ITABLE9264Service TABLE9264Service
        , ITABLE9237Service TABLE9237Service
        , ITABLE9242Service TABLE9242Service
        , ITABLE8604Service TABLE8604Service
        , ITABLE9243Service TABLE9243Service
        , ITABLE9212Service TABLE9212Service
    )
    {
        _service = service;
        _TABLE9264Service = TABLE9264Service;
        _TABLE9237Service = TABLE9237Service;
        _TABLE9242Service = TABLE9242Service;
        _TABLE8604Service = TABLE8604Service;
        _TABLE9243Service = TABLE9243Service;
        _TABLE9212Service = TABLE9212Service;
    }

    // GET: MASTERCL_HIS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MASTERCL_HIS/Index.cshtml");

    // GET: MASTERCL_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_HIS/Details.cshtml", result);
    }

    // GET: MASTERCL_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9243DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_HIS/Create.cshtml", new CreateMASTERCL_HISDto());
    }

    // POST: MASTERCL_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERCL_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9243DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_HIS/Create.cshtml", createDto);
    }

    // GET: MASTERCL_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERCL_HISDto
        {
            NMASTERORDER = result.NMASTERORDER,
            NMOVEMENT = result.NMOVEMENT,
            DMOVEMENT_DATE = result.DMOVEMENT_DATE,
            NSTATORDER_MAST = result.NSTATORDER_MAST,
            NATTENTCHANNEL = result.NATTENTCHANNEL,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            NCURREN_DOC = result.NCURREN_DOC,
            NCURREN_ORDER = result.NCURREN_ORDER,
            NPROVIDER = result.NPROVIDER,
            STYPECARE = result.STYPECARE,
            SCARECLASS = result.SCARECLASS,
            SIND_REV = result.SIND_REV,
            NEXCHANGE = result.NEXCHANGE,
            NMOVEMENT_TYPE = result.NMOVEMENT_TYPE,
            NTRANSAC = result.NTRANSAC,
            SPREAUTHORIZATION = result.SPREAUTHORIZATION,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            NCLAIM = result.NCLAIM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DLEDGERDAT = result.DLEDGERDAT,
            NMASTERORDER_NUM_ORIG = result.NMASTERORDER_NUM_ORIG,
            NMASTERORDER_NUM_GEN = result.NMASTERORDER_NUM_GEN,
        };
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9243DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_HIS/Edit.cshtml", updateDto);
    }

    // POST: MASTERCL_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTERCL_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMASTERORDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9264DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        await PopulateTABLE9243DropdownAsync();
        await PopulateTABLE9212DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_HIS/Edit.cshtml", updateDto);
    }

    // GET: MASTERCL_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_HIS/Delete.cshtml", result);
    }

    // POST: MASTERCL_HIS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9264DropdownAsync()
    {
        var items = await _TABLE9264Service.GetAllAsync();
        ViewData["NSTATORDER_MAST"] = new SelectList(items, nameof(TABLE9264Dto.NSTATORDER_MAST), "SDESCRIPT");
    }

    private async Task PopulateTABLE9237DropdownAsync()
    {
        var items = await _TABLE9237Service.GetAllAsync();
        ViewData["NATTENTCHANNEL"] = new SelectList(items, nameof(TABLE9237Dto.NATTENTCHANNEL), "SDESCRIPT");
    }

    private async Task PopulateTABLE9242DropdownAsync()
    {
        var items = await _TABLE9242Service.GetAllAsync();
        ViewData["NTYPEDOC_PAY"] = new SelectList(items, nameof(TABLE9242Dto.NTYPEDOC_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9243DropdownAsync()
    {
        var items = await _TABLE9243Service.GetAllAsync();
        ViewData["NMOVEMENT_TYPE"] = new SelectList(items, nameof(TABLE9243Dto.NMOVEMENT_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9212DropdownAsync()
    {
        var items = await _TABLE9212Service.GetAllAsync();
        ViewData["NCLAIMANTTYPE"] = new SelectList(items, nameof(TABLE9212Dto.NCLAIMANTTYPE), "SDESCRIPT");
    }

}
