using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_WIN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CLAIM;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLAIM_WINController : Controller
{
    private readonly ICLAIM_WINService _service;
    private readonly ICLAIMService _CLAIMService;

    public CLAIM_WINController(ICLAIM_WINService service
        , ICLAIMService CLAIMService
    )
    {
        _service = service;
        _CLAIMService = CLAIMService;
    }

    // GET: CLAIM_WIN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CLAIM_WIN/Index.cshtml", result);
    }

    // GET: CLAIM_WIN/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_WIN/Details.cshtml", result);
    }

    // GET: CLAIM_WIN/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCLAIMDropdownAsync();
        return View("~/Views/Insudb/CLAIM_WIN/Create.cshtml", new CreateCLAIM_WINDto());
    }

    // POST: CLAIM_WIN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLAIM_WINDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        return View("~/Views/Insudb/CLAIM_WIN/Create.cshtml", createDto);
    }

    // GET: CLAIM_WIN/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLAIM_WINDto
        {
            NCLAIM = result.NCLAIM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SV_CONCLAIM = result.SV_CONCLAIM,
            SV_WINCLAIM = result.SV_WINCLAIM,
        };
        await PopulateCLAIMDropdownAsync();
        return View("~/Views/Insudb/CLAIM_WIN/Edit.cshtml", updateDto);
    }

    // POST: CLAIM_WIN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLAIM_WINDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCLAIMDropdownAsync();
        return View("~/Views/Insudb/CLAIM_WIN/Edit.cshtml", updateDto);
    }

    // GET: CLAIM_WIN/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLAIM_WIN/Delete.cshtml", result);
    }

    // POST: CLAIM_WIN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCLAIMDropdownAsync()
    {
        var items = await _CLAIMService.GetAllAsync();
        ViewData["NCLAIM"] = new SelectList(items, nameof(CLAIMDto.NCLAIM), "SCERTYPE");
    }

}
