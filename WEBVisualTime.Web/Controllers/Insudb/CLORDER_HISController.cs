using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_HIS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9242;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLORDER_HISController : Controller
{
    private readonly ICLORDER_HISService _service;
    private readonly ICLAIM_ORDERService _CLAIM_ORDERService;
    private readonly ITABLE692Service _TABLE692Service;
    private readonly ITABLE9241Service _TABLE9241Service;
    private readonly ITABLE9237Service _TABLE9237Service;
    private readonly ITABLE9242Service _TABLE9242Service;
    private readonly ITABLE11Service _TABLE11Service;
    private readonly ITABLE8604Service _TABLE8604Service;

    public CLORDER_HISController(ICLORDER_HISService service
        , ICLAIM_ORDERService CLAIM_ORDERService
        , ITABLE692Service TABLE692Service
        , ITABLE9241Service TABLE9241Service
        , ITABLE9237Service TABLE9237Service
        , ITABLE9242Service TABLE9242Service
        , ITABLE11Service TABLE11Service
        , ITABLE8604Service TABLE8604Service
    )
    {
        _service = service;
        _CLAIM_ORDERService = CLAIM_ORDERService;
        _TABLE692Service = TABLE692Service;
        _TABLE9241Service = TABLE9241Service;
        _TABLE9237Service = TABLE9237Service;
        _TABLE9242Service = TABLE9242Service;
        _TABLE11Service = TABLE11Service;
        _TABLE8604Service = TABLE8604Service;
    }

    // GET: CLORDER_HIS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLORDER_HIS/Index.cshtml", result);
    }

    // GET: CLORDER_HIS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_HIS/Details.cshtml", result);
    }

    // GET: CLORDER_HIS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        return View("~/Views/Insudb/CLORDER_HIS/Create.cshtml", new CreateCLORDER_HISDto());
    }

    // POST: CLORDER_HIS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLORDER_HISDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        return View("~/Views/Insudb/CLORDER_HIS/Create.cshtml", createDto);
    }

    // GET: CLORDER_HIS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLORDER_HISDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NORDER_NUM = result.NORDER_NUM,
            NMOVEMENT = result.NMOVEMENT,
            DMOVEMENT_DATE = result.DMOVEMENT_DATE,
            NSTATUS_ORDER = result.NSTATUS_ORDER,
            NATTENTCHANNEL = result.NATTENTCHANNEL,
            NTYPEDOC_PAY = result.NTYPEDOC_PAY,
            NCURREN_DOC = result.NCURREN_DOC,
            NCURREN_ORDER = result.NCURREN_ORDER,
            NPROVIDER = result.NPROVIDER,
            STYPECARE = result.STYPECARE,
            SIND_REV = result.SIND_REV,
            NEXCHANGE = result.NEXCHANGE,
            DPOSTED = result.DPOSTED,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NMOVEMENT_TYPE = result.NMOVEMENT_TYPE,
            SCARECLASS = result.SCARECLASS,
            NTRANSAC = result.NTRANSAC,
            SPREAUTHORIZATION = result.SPREAUTHORIZATION,
            SPROLTREATMENT = result.SPROLTREATMENT,
            NPHYSICIAN = result.NPHYSICIAN,
            NMEDICALINSTITUTE = result.NMEDICALINSTITUTE,
            NCLAIMANTTYPE = result.NCLAIMANTTYPE,
            DLEDGERDAT = result.DLEDGERDAT,
            NORDER_NUM_ORIG = result.NORDER_NUM_ORIG,
            NORDER_NUM_GEN = result.NORDER_NUM_GEN,
        };
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        return View("~/Views/Insudb/CLORDER_HIS/Edit.cshtml", updateDto);
    }

    // POST: CLORDER_HIS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLORDER_HISDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIM_ORDERDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE9241DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9242DropdownAsync();
        await PopulateTABLE11DropdownAsync();
        await PopulateTABLE8604DropdownAsync();
        return View("~/Views/Insudb/CLORDER_HIS/Edit.cshtml", updateDto);
    }

    // GET: CLORDER_HIS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLORDER_HIS/Delete.cshtml", result);
    }

    // POST: CLORDER_HIS/Delete/{id}
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
        ViewData["NORDER_NUM"] = new SelectList(items, nameof(CLAIM_ORDERDto.NORDER_NUM), "STYPECARE");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9241DropdownAsync()
    {
        var items = await _TABLE9241Service.GetAllAsync();
        ViewData["NSTATUS_ORDER"] = new SelectList(items, nameof(TABLE9241Dto.NSTATUS_ORDER), "SDESCRIPT");
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

    private async Task PopulateTABLE11DropdownAsync()
    {
        var items = await _TABLE11Service.GetAllAsync();
        ViewData["NCURREN_DOC"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
        ViewData["NCURREN_ORDER"] = new SelectList(items, nameof(TABLE11Dto.NCODIGINT), "SDESCRIPT");
    }

    private async Task PopulateTABLE8604DropdownAsync()
    {
        var items = await _TABLE8604Service.GetAllAsync();
        ViewData["STYPECARE"] = new SelectList(items, nameof(TABLE8604Dto.STYPECARE), "SDESCRIPT");
    }

}
