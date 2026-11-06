using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNP_PAYS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CONTRNPRO;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CONTRNP_PAYSController : Controller
{
    private readonly ICONTRNP_PAYSService _service;
    private readonly ICONTRNPROService _CONTRNPROService;

    public CONTRNP_PAYSController(ICONTRNP_PAYSService service
        , ICONTRNPROService CONTRNPROService
    )
    {
        _service = service;
        _CONTRNPROService = CONTRNPROService;
    }

    // GET: CONTRNP_PAYS
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CONTRNP_PAYS/Index.cshtml");

    // GET: CONTRNP_PAYS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRNP_PAYS/Details.cshtml", result);
    }

    // GET: CONTRNP_PAYS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCONTRNPRODropdownAsync();
        return View("~/Views/Insudb/CONTRNP_PAYS/Create.cshtml", new CreateCONTRNP_PAYSDto());
    }

    // POST: CONTRNP_PAYS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCONTRNP_PAYSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRNPRODropdownAsync();
        return View("~/Views/Insudb/CONTRNP_PAYS/Create.cshtml", createDto);
    }

    // GET: CONTRNP_PAYS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCONTRNP_PAYSDto
        {
            NBRANCH_REI = result.NBRANCH_REI,
            DEFFECDATE = result.DEFFECDATE,
            NNUMBER = result.NNUMBER,
            NTYPE = result.NTYPE,
            NMONTH = result.NMONTH,
            NYEAR = result.NYEAR,
            NAMOUNT = result.NAMOUNT,
            SCUENTECN = result.SCUENTECN,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        await PopulateCONTRNPRODropdownAsync();
        return View("~/Views/Insudb/CONTRNP_PAYS/Edit.cshtml", updateDto);
    }

    // POST: CONTRNP_PAYS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCONTRNP_PAYSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH_REI, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCONTRNPRODropdownAsync();
        return View("~/Views/Insudb/CONTRNP_PAYS/Edit.cshtml", updateDto);
    }

    // GET: CONTRNP_PAYS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CONTRNP_PAYS/Delete.cshtml", result);
    }

    // POST: CONTRNP_PAYS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCONTRNPRODropdownAsync()
    {
        var items = await _CONTRNPROService.GetAllAsync();
        ViewData["NBRANCH_REI"] = new SelectList(items, nameof(CONTRNPRODto.NBRANCH), "SDESCRIPT");
        ViewData["DEFFECDATE"] = new SelectList(items, nameof(CONTRNPRODto.DEFFECDATE), "SDESCRIPT");
        ViewData["NNUMBER"] = new SelectList(items, nameof(CONTRNPRODto.NNUMBER), "SDESCRIPT");
        ViewData["NTYPE"] = new SelectList(items, nameof(CONTRNPRODto.NTYPE), "SDESCRIPT");
    }

}
