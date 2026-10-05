using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCPOL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE12;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIDOCPOLController : Controller
{
    private readonly ICLIDOCPOLService _service;
    private readonly ITABLE12Service _TABLE12Service;
    private readonly IFORMATVALUESService _FORMATVALUESService;

    public CLIDOCPOLController(ICLIDOCPOLService service
        , ITABLE12Service TABLE12Service
        , IFORMATVALUESService FORMATVALUESService
    )
    {
        _service = service;
        _TABLE12Service = TABLE12Service;
        _FORMATVALUESService = FORMATVALUESService;
    }

    // GET: CLIDOCPOL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLIDOCPOL/Index.cshtml", result);
    }

    // GET: CLIDOCPOL/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIDOCPOL/Details.cshtml", result);
    }

    // GET: CLIDOCPOL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE12DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/CLIDOCPOL/Create.cshtml", new CreateCLIDOCPOLDto());
    }

    // POST: CLIDOCPOL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIDOCPOLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/CLIDOCPOL/Create.cshtml", createDto);
    }

    // GET: CLIDOCPOL/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIDOCPOLDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NROLE = result.NROLE,
            SCLIENT = result.SCLIENT,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            DRECEP_DATE = result.DRECEP_DATE,
            DDATEVIG = result.DDATEVIG,
            NSTAT_DOCREQ = result.NSTAT_DOCREQ,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            DLIMIT_DATE = result.DLIMIT_DATE,
            NID_SECUENCIA = result.NID_SECUENCIA,
        };
        await PopulateTABLE12DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/CLIDOCPOL/Edit.cshtml", updateDto);
    }

    // POST: CLIDOCPOL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIDOCPOLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE12DropdownAsync();
        await PopulateFORMATVALUESDropdownAsync();
        return View("~/Views/Insudb/CLIDOCPOL/Edit.cshtml", updateDto);
    }

    // GET: CLIDOCPOL/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIDOCPOL/Delete.cshtml", result);
    }

    // POST: CLIDOCPOL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE12DropdownAsync()
    {
        var items = await _TABLE12Service.GetAllAsync();
        ViewData["NROLE"] = new SelectList(items, nameof(TABLE12Dto.NROLE), "SDESCRIPT");
    }

    private async Task PopulateFORMATVALUESDropdownAsync()
    {
        var items = await _FORMATVALUESService.GetAllAsync();
        ViewData["NCLASSTYPDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NCLASSTYPDOC), "SDESCRIPT");
        ViewData["NTYPCLIENTDOC"] = new SelectList(items, nameof(FORMATVALUESDto.NTYPCLIENTDOC), "SDESCRIPT");
    }

}
