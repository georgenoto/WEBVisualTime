using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5529;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5581;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class AGREEMENTController : Controller
{
    private readonly IAGREEMENTService _service;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE5529Service _TABLE5529Service;
    private readonly ITABLE5581Service _TABLE5581Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE5555Service _TABLE5555Service;

    public AGREEMENTController(IAGREEMENTService service
        , ICLIENTService CLIENTService
        , ITABLE5529Service TABLE5529Service
        , ITABLE5581Service TABLE5581Service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE5555Service TABLE5555Service
    )
    {
        _service = service;
        _CLIENTService = CLIENTService;
        _TABLE5529Service = TABLE5529Service;
        _TABLE5581Service = TABLE5581Service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE5555Service = TABLE5555Service;
    }

    // GET: AGREEMENT
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/AGREEMENT/Index.cshtml");

    // GET: AGREEMENT/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGREEMENT/Details.cshtml", result);
    }

    // GET: AGREEMENT/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5529DropdownAsync();
        await PopulateTABLE5581DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/AGREEMENT/Create.cshtml", new CreateAGREEMENTDto());
    }

    // POST: AGREEMENT/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAGREEMENTDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5529DropdownAsync();
        await PopulateTABLE5581DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/AGREEMENT/Create.cshtml", createDto);
    }

    // GET: AGREEMENT/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateAGREEMENTDto
        {
            SCLIENT = result.SCLIENT,
            NCOD_AGREE = result.NCOD_AGREE,
            NQ_DRAFT = result.NQ_DRAFT,
            NMAX_PERC_DCTO = result.NMAX_PERC_DCTO,
            DINIT_DATE = result.DINIT_DATE,
            DEND_DATE = result.DEND_DATE,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            NTYPEAGREE = result.NTYPEAGREE,
            NTYPE_REC = result.NTYPE_REC,
            NINTERMED = result.NINTERMED,
            NAGENCY = result.NAGENCY,
            SEMAIL_CONTACT = result.SEMAIL_CONTACT,
            SPHONE_CONTACT = result.SPHONE_CONTACT,
            SCLIENAME = result.SCLIENAME,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            NPOSITION = result.NPOSITION,
            SEMAILA_CONTACT = result.SEMAILA_CONTACT,
            SPHONEA_CONTACT = result.SPHONEA_CONTACT,
            SPHONEFAX = result.SPHONEFAX,
            SNAME_AGREE = result.SNAME_AGREE,
            SNOCOLLECTION = result.SNOCOLLECTION,
            NIMAGENUM = result.NIMAGENUM,
            NPROV_GROUP = result.NPROV_GROUP,
            NPROVIDER = result.NPROVIDER,
        };
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5529DropdownAsync();
        await PopulateTABLE5581DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/AGREEMENT/Edit.cshtml", updateDto);
    }

    // POST: AGREEMENT/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateAGREEMENTDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCOD_AGREE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE5529DropdownAsync();
        await PopulateTABLE5581DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/AGREEMENT/Edit.cshtml", updateDto);
    }

    // GET: AGREEMENT/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/AGREEMENT/Delete.cshtml", result);
    }

    // POST: AGREEMENT/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: AGREEMENT/GetBySCLIENT?SCLIENT=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCLIENT(string SCLIENT)
    {
        var items = await _service.FindAsync(p => p.SCLIENT == SCLIENT);
        return Json(items.Select(i => new { value = i.NCOD_AGREE, text = i.SSTATREGT }));
    }

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE5529DropdownAsync()
    {
        var items = await _TABLE5529Service.GetAllAsync();
        ViewData["NTYPEAGREE"] = new SelectList(items, nameof(TABLE5529Dto.NTYPEAGREE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5581DropdownAsync()
    {
        var items = await _TABLE5581Service.GetAllAsync();
        ViewData["NTYPE_REC"] = new SelectList(items, nameof(TABLE5581Dto.NTYPE_REC), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

}
