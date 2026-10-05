using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAUS_CO_P;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAUS_CO_PController : Controller
{
    private readonly ICLAUS_CO_PService _service;
    private readonly IPOLICYService _POLICYService;

    public CLAUS_CO_PController(ICLAUS_CO_PService service
        , IPOLICYService POLICYService
    )
    {
        _service = service;
        _POLICYService = POLICYService;
    }

    // GET: CLAUS_CO_P
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAUS_CO_P/Index.cshtml", result);
    }

    // GET: CLAUS_CO_P/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUS_CO_P/Details.cshtml", result);
    }

    // GET: CLAUS_CO_P/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/CLAUS_CO_P/Create.cshtml", new CreateCLAUS_CO_PDto());
    }

    // POST: CLAUS_CO_P/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAUS_CO_PDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/CLAUS_CO_P/Create.cshtml", createDto);
    }

    // GET: CLAUS_CO_P/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAUS_CO_PDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCLAUSE = result.NCLAUSE,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            NNOTENUM = result.NNOTENUM,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            STYPE_CLAUSE = result.STYPE_CLAUSE,
            SDOC_ATTACH = result.SDOC_ATTACH,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/CLAUS_CO_P/Edit.cshtml", updateDto);
    }

    // POST: CLAUS_CO_P/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAUS_CO_PDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePOLICYDropdownAsync();
        return View("~/Views/Insudb/CLAUS_CO_P/Edit.cshtml", updateDto);
    }

    // GET: CLAUS_CO_P/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAUS_CO_P/Delete.cshtml", result);
    }

    // POST: CLAUS_CO_P/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePOLICYDropdownAsync()
    {
        var items = await _POLICYService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(POLICYDto.SCERTYPE), "SACCOUNTI");
        ViewData["NBRANCH"] = new SelectList(items, nameof(POLICYDto.NBRANCH), "SACCOUNTI");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(POLICYDto.NPRODUCT), "SACCOUNTI");
        ViewData["NPOLICY"] = new SelectList(items, nameof(POLICYDto.NPOLICY), "SACCOUNTI");
    }

}
