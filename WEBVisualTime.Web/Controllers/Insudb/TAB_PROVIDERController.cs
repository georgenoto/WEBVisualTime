using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROVIDER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_SUBTYPES;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5570;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9253;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9259;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9254;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9255;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9256;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_PROVIDERController : Controller
{
    private readonly ITAB_PROVIDERService _service;
    private readonly ITAB_PROV_SUBTYPESService _TAB_PROV_SUBTYPESService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE5570Service _TABLE5570Service;
    private readonly ITABLE9253Service _TABLE9253Service;
    private readonly ITABLE9259Service _TABLE9259Service;
    private readonly ITABLE9254Service _TABLE9254Service;
    private readonly ITABLE9252Service _TABLE9252Service;
    private readonly ITABLE9255Service _TABLE9255Service;
    private readonly ITABLE9256Service _TABLE9256Service;

    public TAB_PROVIDERController(ITAB_PROVIDERService service
        , ITAB_PROV_SUBTYPESService TAB_PROV_SUBTYPESService
        , ICLIENTService CLIENTService
        , ITABLE9Service TABLE9Service
        , ITABLE5570Service TABLE5570Service
        , ITABLE9253Service TABLE9253Service
        , ITABLE9259Service TABLE9259Service
        , ITABLE9254Service TABLE9254Service
        , ITABLE9252Service TABLE9252Service
        , ITABLE9255Service TABLE9255Service
        , ITABLE9256Service TABLE9256Service
    )
    {
        _service = service;
        _TAB_PROV_SUBTYPESService = TAB_PROV_SUBTYPESService;
        _CLIENTService = CLIENTService;
        _TABLE9Service = TABLE9Service;
        _TABLE5570Service = TABLE5570Service;
        _TABLE9253Service = TABLE9253Service;
        _TABLE9259Service = TABLE9259Service;
        _TABLE9254Service = TABLE9254Service;
        _TABLE9252Service = TABLE9252Service;
        _TABLE9255Service = TABLE9255Service;
        _TABLE9256Service = TABLE9256Service;
    }

    // GET: TAB_PROVIDER
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_PROVIDER/Index.cshtml", result);
    }

    // GET: TAB_PROVIDER/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROVIDER/Details.cshtml", result);
    }

    // GET: TAB_PROVIDER/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_PROV_SUBTYPESDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE9253DropdownAsync();
        await PopulateTABLE9259DropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9255DropdownAsync();
        await PopulateTABLE9256DropdownAsync();
        return View("~/Views/Insudb/TAB_PROVIDER/Create.cshtml", new CreateTAB_PROVIDERDto());
    }

    // POST: TAB_PROVIDER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_PROVIDERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROV_SUBTYPESDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE9253DropdownAsync();
        await PopulateTABLE9259DropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9255DropdownAsync();
        await PopulateTABLE9256DropdownAsync();
        return View("~/Views/Insudb/TAB_PROVIDER/Create.cshtml", createDto);
    }

    // GET: TAB_PROVIDER/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_PROVIDERDto
        {
            NPROVIDER = result.NPROVIDER,
            NTYPEPROV = result.NTYPEPROV,
            SCLIENT = result.SCLIENT,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            DINPDATE = result.DINPDATE,
            DOUTDATE = result.DOUTDATE,
            NOFFICE = result.NOFFICE,
            NMAX_SERV_ORD = result.NMAX_SERV_ORD,
            NTYPESUPPORT = result.NTYPESUPPORT,
            NPER_DISC = result.NPER_DISC,
            SCONCESIONARY = result.SCONCESIONARY,
            SAGENCYDESC = result.SAGENCYDESC,
            NCLASS_PROV = result.NCLASS_PROV,
            NCATEG_PROV = result.NCATEG_PROV,
            NTYPEDISC_PROV = result.NTYPEDISC_PROV,
            NSUBTYPEPROV = result.NSUBTYPEPROV,
            DREQDATE = result.DREQDATE,
            DREGDATE = result.DREGDATE,
            NDISC_PROV = result.NDISC_PROV,
            NCURRDISC_PROV = result.NCURRDISC_PROV,
            NAMODISC_PROV = result.NAMODISC_PROV,
            NPAYMENT_METHOD = result.NPAYMENT_METHOD,
            NJOINED = result.NJOINED,
            NCOD_INSTEDUC = result.NCOD_INSTEDUC,
            NCOD_MEDCOLLEGE = result.NCOD_MEDCOLLEGE,
            SINTERNATIONALPROVIDER = result.SINTERNATIONALPROVIDER,
        };
        await PopulateTAB_PROV_SUBTYPESDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE9253DropdownAsync();
        await PopulateTABLE9259DropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9255DropdownAsync();
        await PopulateTABLE9256DropdownAsync();
        return View("~/Views/Insudb/TAB_PROVIDER/Edit.cshtml", updateDto);
    }

    // POST: TAB_PROVIDER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_PROVIDERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NPROVIDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_PROV_SUBTYPESDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5570DropdownAsync();
        await PopulateTABLE9253DropdownAsync();
        await PopulateTABLE9259DropdownAsync();
        await PopulateTABLE9254DropdownAsync();
        await PopulateTABLE9252DropdownAsync();
        await PopulateTABLE9255DropdownAsync();
        await PopulateTABLE9256DropdownAsync();
        return View("~/Views/Insudb/TAB_PROVIDER/Edit.cshtml", updateDto);
    }

    // GET: TAB_PROVIDER/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_PROVIDER/Delete.cshtml", result);
    }

    // POST: TAB_PROVIDER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: TAB_PROVIDER/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NPROVIDER, text = i.SSTATREGT }));
    }

    // GET: TAB_PROVIDER/GetByNOFFICE?NOFFICE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNOFFICE(int NOFFICE)
    {
        var items = await _service.FindAsync(p => p.NOFFICE == NOFFICE);
        return Json(items.Select(i => new { value = i.NPROVIDER, text = i.SSTATREGT }));
    }

    private async Task PopulateTAB_PROV_SUBTYPESDropdownAsync()
    {
        var items = await _TAB_PROV_SUBTYPESService.GetAllAsync();
        ViewData["NTYPEPROV"] = new SelectList(items, nameof(TAB_PROV_SUBTYPESDto.NTYPEPROV), "SDESCRIPT");
        ViewData["NSUBTYPEPROV"] = new SelectList(items, nameof(TAB_PROV_SUBTYPESDto.NSUBTYPEPROV), "SDESCRIPT");
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5570DropdownAsync()
    {
        var items = await _TABLE5570Service.GetAllAsync();
        ViewData["NTYPESUPPORT"] = new SelectList(items, nameof(TABLE5570Dto.NTYPESUPPORT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9253DropdownAsync()
    {
        var items = await _TABLE9253Service.GetAllAsync();
        ViewData["NCLASS_PROV"] = new SelectList(items, nameof(TABLE9253Dto.NCLASS_PROV), "SDESCRIPT");
    }

    private async Task PopulateTABLE9259DropdownAsync()
    {
        var items = await _TABLE9259Service.GetAllAsync();
        ViewData["NCATEG_PROV"] = new SelectList(items, nameof(TABLE9259Dto.NCATEG_PROV), "SDESCRIPT");
    }

    private async Task PopulateTABLE9254DropdownAsync()
    {
        var items = await _TABLE9254Service.GetAllAsync();
        ViewData["NTYPEDISC_PROV"] = new SelectList(items, nameof(TABLE9254Dto.NTYPEDISC_PROV), "SDESCRIPT");
    }

    private async Task PopulateTABLE9252DropdownAsync()
    {
        var items = await _TABLE9252Service.GetAllAsync();
        ViewData["NPAYMENT_METHOD"] = new SelectList(items, nameof(TABLE9252Dto.NPAYMENT_METHOD), "SDESCRIPT");
    }

    private async Task PopulateTABLE9255DropdownAsync()
    {
        var items = await _TABLE9255Service.GetAllAsync();
        ViewData["NCOD_INSTEDUC"] = new SelectList(items, nameof(TABLE9255Dto.NCOD_INSTEDUC), "SDESCRIPT");
    }

    private async Task PopulateTABLE9256DropdownAsync()
    {
        var items = await _TABLE9256Service.GetAllAsync();
        ViewData["NCOD_MEDCOLLEGE"] = new SelectList(items, nameof(TABLE9256Dto.NCOD_MEDCOLLEGE), "SDESCRIPT");
    }

}
