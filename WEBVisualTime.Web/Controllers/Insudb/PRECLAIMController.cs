using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PRECLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9238;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_ORDER;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PRECLAIMController : Controller
{
    private readonly IPRECLAIMService _service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE9237Service _TABLE9237Service;
    private readonly ITABLE9238Service _TABLE9238Service;
    private readonly IMASTERCL_ORDERService _MASTERCL_ORDERService;
    private readonly ITABLE210Service _TABLE210Service;

    public PRECLAIMController(IPRECLAIMService service
        , IUSERSService USERSService
        , ITABLE9Service TABLE9Service
        , ITABLE9237Service TABLE9237Service
        , ITABLE9238Service TABLE9238Service
        , IMASTERCL_ORDERService MASTERCL_ORDERService
        , ITABLE210Service TABLE210Service
    )
    {
        _service = service;
        _USERSService = USERSService;
        _TABLE9Service = TABLE9Service;
        _TABLE9237Service = TABLE9237Service;
        _TABLE9238Service = TABLE9238Service;
        _MASTERCL_ORDERService = MASTERCL_ORDERService;
        _TABLE210Service = TABLE210Service;
    }

    // GET: PRECLAIM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PRECLAIM/Index.cshtml", result);
    }

    // GET: PRECLAIM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRECLAIM/Details.cshtml", result);
    }

    // GET: PRECLAIM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/PRECLAIM/Create.cshtml", new CreatePRECLAIMDto());
    }

    // POST: PRECLAIM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePRECLAIMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/PRECLAIM/Create.cshtml", createDto);
    }

    // GET: PRECLAIM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePRECLAIMDto
        {
            NIDPRECLAIM = result.NIDPRECLAIM,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DOCCURDATE = result.DOCCURDATE,
            DREPDATE = result.DREPDATE,
            SADDRESS = result.SADDRESS,
            NDAMAGES = result.NDAMAGES,
            NCURRENCY = result.NCURRENCY,
            NIDSTATPRECLAIM = result.NIDSTATPRECLAIM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NPRECLAIM = result.NPRECLAIM,
            SNAMECLIENT = result.SNAMECLIENT,
            NNOTENUM = result.NNOTENUM,
            SCLIENT_AFFECT = result.SCLIENT_AFFECT,
            NOFFICE = result.NOFFICE,
            NATTENTCHANNEL = result.NATTENTCHANNEL,
            SCLINUMDOCU = result.SCLINUMDOCU,
            NCOUNTRY = result.NCOUNTRY,
            SLOCALOCCUR = result.SLOCALOCCUR,
            SACCIDENT = result.SACCIDENT,
            SPREAUTHORIZATION = result.SPREAUTHORIZATION,
            NORDERTYPE = result.NORDERTYPE,
            DSTATUS = result.DSTATUS,
            DREJECTION = result.DREJECTION,
            DREJECTNOTICE = result.DREJECTNOTICE,
            NREJECTUSER = result.NREJECTUSER,
            NMASTERORDER = result.NMASTERORDER,
            NPROVIDER = result.NPROVIDER,
            NPHYSICIAN = result.NPHYSICIAN,
            NMEDICALINSTITUTE = result.NMEDICALINSTITUTE,
            SCALLCENTER = result.SCALLCENTER,
            DLEDGERDAT = result.DLEDGERDAT,
            NCLA_LI_TYP = result.NCLA_LI_TYP,
            NCAUSEREOPENCL = result.NCAUSEREOPENCL,
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            DREOPENCL = result.DREOPENCL,
            NREOPENUSER = result.NREOPENUSER,
            DCONFREJECTION = result.DCONFREJECTION,
            DCONFREJECTNOTICE = result.DCONFREJECTNOTICE,
            NCONFREJECTUSER = result.NCONFREJECTUSER,
            DNULLDATE = result.DNULLDATE,
            NNULLCODE = result.NNULLCODE,
            SHISTORICAL_CLAIM = result.SHISTORICAL_CLAIM,
        };
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/PRECLAIM/Edit.cshtml", updateDto);
    }

    // POST: PRECLAIM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePRECLAIMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPRECLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE9237DropdownAsync();
        await PopulateTABLE9238DropdownAsync();
        await PopulateMASTERCL_ORDERDropdownAsync();
        await PopulateTABLE210DropdownAsync();
        return View("~/Views/Insudb/PRECLAIM/Edit.cshtml", updateDto);
    }

    // GET: PRECLAIM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PRECLAIM/Delete.cshtml", result);
    }

    // POST: PRECLAIM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: PRECLAIM/GetByNUSERCODE?NUSERCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNUSERCODE(int NUSERCODE)
    {
        var items = await _service.FindAsync(p => p.NUSERCODE == NUSERCODE);
        return Json(items.Select(i => new { value = i.NIDPRECLAIM, text = i.SCERTYPE }));
    }

    // GET: PRECLAIM/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NIDPRECLAIM, text = i.SCERTYPE }));
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9237DropdownAsync()
    {
        var items = await _TABLE9237Service.GetAllAsync();
        ViewData["NATTENTCHANNEL"] = new SelectList(items, nameof(TABLE9237Dto.NATTENTCHANNEL), "SDESCRIPT");
    }

    private async Task PopulateTABLE9238DropdownAsync()
    {
        var items = await _TABLE9238Service.GetAllAsync();
        ViewData["NORDERTYPE"] = new SelectList(items, nameof(TABLE9238Dto.NORDERTYPE), "SDESCRIPT");
    }

    private async Task PopulateMASTERCL_ORDERDropdownAsync()
    {
        var items = await _MASTERCL_ORDERService.GetAllAsync();
        ViewData["NMASTERORDER"] = new SelectList(items, nameof(MASTERCL_ORDERDto.NMASTERORDER), "SNAMECLIENT");
    }

    private async Task PopulateTABLE210DropdownAsync()
    {
        var items = await _TABLE210Service.GetAllAsync();
        ViewData["NCLA_LI_TYP"] = new SelectList(items, nameof(TABLE210Dto.NCLA_LI_TYP), "SDESCRIPT");
    }

}
