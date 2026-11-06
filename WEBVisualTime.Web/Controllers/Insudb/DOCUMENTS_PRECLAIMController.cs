using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS_PRECLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9217;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9219;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DOCUMENTS_PRECLAIMController : Controller
{
    private readonly IDOCUMENTS_PRECLAIMService _service;
    private readonly ITABLE203Service _TABLE203Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9217Service _TABLE9217Service;
    private readonly ITAB_PROVIDERService _TAB_PROVIDERService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE9219Service _TABLE9219Service;

    public DOCUMENTS_PRECLAIMController(IDOCUMENTS_PRECLAIMService service
        , ITABLE203Service TABLE203Service
        , IUSERSService USERSService
        , ITABLE9217Service TABLE9217Service
        , ITAB_PROVIDERService TAB_PROVIDERService
        , ICLIENTService CLIENTService
        , ITABLE9219Service TABLE9219Service
    )
    {
        _service = service;
        _TABLE203Service = TABLE203Service;
        _USERSService = USERSService;
        _TABLE9217Service = TABLE9217Service;
        _TAB_PROVIDERService = TAB_PROVIDERService;
        _CLIENTService = CLIENTService;
        _TABLE9219Service = TABLE9219Service;
    }

    // GET: DOCUMENTS_PRECLAIM
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DOCUMENTS_PRECLAIM/Index.cshtml");

    // GET: DOCUMENTS_PRECLAIM/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Details.cshtml", result);
    }

    // GET: DOCUMENTS_PRECLAIM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9219DropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Create.cshtml", new CreateDOCUMENTS_PRECLAIMDto());
    }

    // POST: DOCUMENTS_PRECLAIM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDOCUMENTS_PRECLAIMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9219DropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Create.cshtml", createDto);
    }

    // GET: DOCUMENTS_PRECLAIM/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDOCUMENTS_PRECLAIMDto
        {
            NIDPRECLAIM = result.NIDPRECLAIM,
            NCONSEC = result.NCONSEC,
            NDOC_CODE = result.NDOC_CODE,
            NDOCNUMBE = result.NDOCNUMBE,
            DRECEPDATE = result.DRECEPDATE,
            DPROPO_DATE = result.DPROPO_DATE,
            DPRESCDATE = result.DPRESCDATE,
            NSTATUS_DOC = result.NSTATUS_DOC,
            NAMOUNT = result.NAMOUNT,
            NCURRENCY = result.NCURRENCY,
            NQUANTITY = result.NQUANTITY,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NDOC_TYPE = result.NDOC_TYPE,
            NPROVIDER = result.NPROVIDER,
            SCLIENT = result.SCLIENT,
            NID_SECUENCIA = result.NID_SECUENCIA,
            NCLASS_DOC = result.NCLASS_DOC,
            SOBSERVATIONS = result.SOBSERVATIONS,
        };
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9219DropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Edit.cshtml", updateDto);
    }

    // POST: DOCUMENTS_PRECLAIM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDOCUMENTS_PRECLAIMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPRECLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE203DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9217DropdownAsync();
        await PopulateTAB_PROVIDERDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9219DropdownAsync();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Edit.cshtml", updateDto);
    }

    // GET: DOCUMENTS_PRECLAIM/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DOCUMENTS_PRECLAIM/Delete.cshtml", result);
    }

    // POST: DOCUMENTS_PRECLAIM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE9219DropdownAsync()
    {
        var items = await _TABLE9219Service.GetAllAsync();
        ViewData["NCLASS_DOC"] = new SelectList(items, nameof(TABLE9219Dto.NCLASS_DOC), "SDESCRIPT");
    }

}
