using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5551;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5557;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class COLLECTORController : Controller
{
    private readonly ICOLLECTORService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5551Service _TABLE5551Service;
    private readonly ITABLE5557Service _TABLE5557Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ITAB_COLLECTCOMMService _TAB_COLLECTCOMMService;
    private readonly ITABLE5501Service _TABLE5501Service;

    public COLLECTORController(ICOLLECTORService service
        , ICLIENTService CLIENTService
        , ITABLE5551Service TABLE5551Service
        , ITABLE5557Service TABLE5557Service
        , ITABLE5001Service TABLE5001Service
        , ITAB_COLLECTCOMMService TAB_COLLECTCOMMService
        , ITABLE5501Service TABLE5501Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE5551Service = TABLE5551Service;
        _TABLE5557Service = TABLE5557Service;
        _TABLE5001Service = TABLE5001Service;
        _TAB_COLLECTCOMMService = TAB_COLLECTCOMMService;
        _TABLE5501Service = TABLE5501Service;
    }

    // GET: COLLECTOR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/COLLECTOR/Index.cshtml", result);
    }

    // GET: COLLECTOR/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLLECTOR/Details.cshtml", result);
    }

    // GET: COLLECTOR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5551DropdownAsync();
        await PopulateTABLE5557DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTAB_COLLECTCOMMDropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        return View("~/Views/Insudb/COLLECTOR/Create.cshtml", new CreateCOLLECTORDto());
    }

    // POST: COLLECTOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCOLLECTORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5551DropdownAsync();
        await PopulateTABLE5557DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTAB_COLLECTCOMMDropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        return View("~/Views/Insudb/COLLECTOR/Create.cshtml", createDto);
    }

    // GET: COLLECTOR/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCOLLECTORDto
        {
            NCOLLECTOR = result.NCOLLECTOR,
            SCLIENT = result.SCLIENT,
            NCOLLECTORTYPE = result.NCOLLECTORTYPE,
            DINPUTDATE = result.DINPUTDATE,
            NCONTYPE = result.NCONTYPE,
            NINSUR_AREA = result.NINSUR_AREA,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NCODE = result.NCODE,
            NLEGAL_SCH = result.NLEGAL_SCH,
            NINT_STATUS = result.NINT_STATUS,
            DSTATUSDATE = result.DSTATUSDATE,
            NOFFICE = result.NOFFICE,
            NSUPERVIS = result.NSUPERVIS,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5551DropdownAsync();
        await PopulateTABLE5557DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTAB_COLLECTCOMMDropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        return View("~/Views/Insudb/COLLECTOR/Edit.cshtml", updateDto);
    }

    // POST: COLLECTOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCOLLECTORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOLLECTOR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5551DropdownAsync();
        await PopulateTABLE5557DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTAB_COLLECTCOMMDropdownAsync();
        await PopulateTABLE5501DropdownAsync();
        return View("~/Views/Insudb/COLLECTOR/Edit.cshtml", updateDto);
    }

    // GET: COLLECTOR/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/COLLECTOR/Delete.cshtml", result);
    }

    // POST: COLLECTOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: COLLECTOR/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NCOLLECTOR, text = i.NCOLLECTOR }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5551DropdownAsync()
    {
        var items = await _TABLE5551Service.GetAllAsync();
        ViewData["NCOLLECTORTYPE"] = new SelectList(items, nameof(TABLE5551Dto.NCOLLECTORTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5557DropdownAsync()
    {
        var items = await _TABLE5557Service.GetAllAsync();
        ViewData["NCONTYPE"] = new SelectList(items, nameof(TABLE5557Dto.NCONTYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateTAB_COLLECTCOMMDropdownAsync()
    {
        var items = await _TAB_COLLECTCOMMService.GetAllAsync();
        ViewData["NCODE"] = new SelectList(items, nameof(TAB_COLLECTCOMMDto.NCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5501DropdownAsync()
    {
        var items = await _TABLE5501Service.GetAllAsync();
        ViewData["NLEGAL_SCH"] = new SelectList(items, nameof(TABLE5501Dto.NLEGAL_SCH), "SDESCRIPT");
    }

}
