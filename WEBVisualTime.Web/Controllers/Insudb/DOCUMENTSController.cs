using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIMBENEF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9217;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DOCUMENTSController : Controller
{
    private readonly IDOCUMENTSService _service;
    private readonly ICLAIMBENEFService _CLAIMBENEFService;
    private readonly ITABLE692Service _TABLE692Service;
    private readonly ITABLE203Service _TABLE203Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9217Service _TABLE9217Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;

    public DOCUMENTSController(IDOCUMENTSService service
        , ICLAIMBENEFService CLAIMBENEFService
        , ITABLE692Service TABLE692Service
        , ITABLE203Service TABLE203Service
        , IUSERSService USERSService
        , ITABLE9217Service TABLE9217Service
        , ITAB_PROVIDERService TAB_PROVIDERService
    )
    {
        _service = service;
        _CLAIMBENEFService = CLAIMBENEFService;
        _TABLE692Service = TABLE692Service;
        _TABLE203Service = TABLE203Service;
        _USERSService = USERSService;
        _TABLE9217Service = TABLE9217Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
    }

    // GET: DOCUMENTS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DOCUMENTS/Index.cshtml");

    // GET: DOCUMENTS/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOCUMENTS/Details.cshtml", result);
    }

    // GET: DOCUMENTS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIMBENEFDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS/Create.cshtml", new CreateDOCUMENTSDto());
    }

    // POST: DOCUMENTS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDOCUMENTSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMBENEFDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS/Create.cshtml", createDto);
    }

    // GET: DOCUMENTS/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDOCUMENTSDto
        {
            NCLAIM = result.NCLAIM,
            NDOC_CODE = result.NDOC_CODE,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            SCLIENT = result.SCLIENT,
            NID = result.NID,
            DCOMPDATE = result.DCOMPDATE,
            DEFFECDATE = result.DEFFECDATE,
            DLETFIRSDAT = result.DLETFIRSDAT,
            DLETLASTDAT = result.DLETLASTDAT,
            DRECEPDATE = result.DRECEPDATE,
            NSTATUS_DOC = result.NSTATUS_DOC,
            NUSERCODE = result.NUSERCODE,
            NDOCNUMBE = result.NDOCNUMBE,
            NQUANTITY = result.NQUANTITY,
            DPROPO_DATE = result.DPROPO_DATE,
            DPRESCDATE = result.DPRESCDATE,
            NCONSEC = result.NCONSEC,
            SDESCRIPT = result.SDESCRIPT,
            NAMOUNT = result.NAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NDOC_TYPE = result.NDOC_TYPE,
            NPROVIDER = result.NPROVIDER,
            NID_SECUENCIA = result.NID_SECUENCIA,
            NCLASS_DOC = result.NCLASS_DOC,
            SOBSERVATIONS = result.SOBSERVATIONS,
        };
        await PopulateCLAIMBENEFDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS/Edit.cshtml", updateDto);
    }

    // POST: DOCUMENTS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDOCUMENTSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMBENEFDropdownAsync();
        await PopulateTABLE692DropdownAsync();
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS/Edit.cshtml", updateDto);
    }

    // GET: DOCUMENTS/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOCUMENTS/Delete.cshtml", result);
    }

    // POST: DOCUMENTS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: DOCUMENTS/GetByNDEMAN_TYPE?NDEMAN_TYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNDEMAN_TYPE(int NDEMAN_TYPE)
    {
        var items = await _service.FindAsync(p => p.NDEMAN_TYPE == NDEMAN_TYPE);
        return Json(items.Select(i => new { value = i.NCLAIM, text = i.SDESCRIPT }));
    }

    private async Task PopulateCLAIMBENEFDropdownAsync()
    {
        var items = await _CLAIMBENEFService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMBENEFDto.NCLAIM), "SDEMANDANT");
        ViewData["NCASE_NUM"] = new SelectList(items, nameof(CLAIMBENEFDto.NCASE_NUM), "SDEMANDANT");
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLAIMBENEFDto.SCLIENT), "SDEMANDANT");
        ViewData["NID"] = new SelectList(items, nameof(CLAIMBENEFDto.NID), "SDEMANDANT");
    }

    private async Task PopulateTABLE692DropdownAsync()
    {
        var items = await _TABLE692Service.GetAllAsync();
        ViewData["NDEMAN_TYPE"] = new SelectList(items, nameof(TABLE692Dto.NDEMAN_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE203DropdownAsync()
    {
        var items = await _TABLE203Service.GetAllAsync();
        ViewData["NSTATUS_DOC"] = new SelectList(items, nameof(TABLE203Dto.NSTATUS_DOC), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE9217DropdownAsync()
    {
        var items = await _TABLE9217Service.GetAllAsync();
        ViewData["NDOC_TYPE"] = new SelectList(items, nameof(TABLE9217Dto.NDOC_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTAB_PROVIDERDropdownAsync()
    {
        var items = await _TAB_PROVIDERService.GetAllAsync();
        ViewData["NPROVIDER"] = new SelectList(items, nameof(TAB_PROVIDERDto.NPROVIDER), "SSTATREGT");
    }

}
