using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLDOCREQ;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOPRO;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ROLDOCREQController : Controller
{
    private readonly IROLDOCREQService _service;
    private readonly ICLIALLOPROService _CLIALLOPROService;
    private readonly IFORMATVALUESService _FORMATVALUESService;

    public ROLDOCREQController(IROLDOCREQService service
        , ICLIALLOPROService CLIALLOPROService
        , IFORMATVALUESService FORMATVALUESService
    )
    {
        _service = service;
        _CLIALLOPROService = CLIALLOPROService;
        _FORMATVALUESService = FORMATVALUESService;
    }

    // GET: ROLDOCREQ
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ROLDOCREQ/Index.cshtml");

    // GET: ROLDOCREQ/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLDOCREQ/Details.cshtml", result);
    }

    // GET: ROLDOCREQ/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLIALLOPRODropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/ROLDOCREQ/Create.cshtml", new CreateROLDOCREQDto());
    }

    // POST: ROLDOCREQ/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateROLDOCREQDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIALLOPRODropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/ROLDOCREQ/Create.cshtml", createDto);
    }

    // GET: ROLDOCREQ/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateROLDOCREQDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SPOLITYPE = result.SPOLITYPE,
            SCOMPON = result.SCOMPON,
            NROLE = result.NROLE,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCLIALLOPRODropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/ROLDOCREQ/Edit.cshtml", updateDto);
    }

    // POST: ROLDOCREQ/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateROLDOCREQDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLIALLOPRODropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/ROLDOCREQ/Edit.cshtml", updateDto);
    }

    // GET: ROLDOCREQ/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLDOCREQ/Delete.cshtml", result);
    }

    // POST: ROLDOCREQ/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLIALLOPRODropdownAsync()
    {
        var items = await _CLIALLOPROService.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(CLIALLOPRODto.NBRANCH), "SDEFAULTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CLIALLOPRODto.NPRODUCT), "SDEFAULTI");
        ViewData["SPOLITYPE"] = new SelectList(items, nameof(CLIALLOPRODto.SPOLITYPE), "SDEFAULTI");
        ViewData["SCOMPON"] = new SelectList(items, nameof(CLIALLOPRODto.SCOMPON), "SDEFAULTI");
        ViewData["NROLE"] = new SelectList(items, nameof(CLIALLOPRODto.NROLE), "SDEFAULTI");
    }

    private async Task PopulateFORMATVALUESDropdownAsync()
    {
        var items = await _FORMATVALUESService.GetAllAsync();
        ViewData["NCLASSTYPDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NCLASSTYPDOC), "SDESCRIPT");
        ViewData["NTYPCLIENTDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NTYPCLIENTDOC), "SDESCRIPT");
    }

}
