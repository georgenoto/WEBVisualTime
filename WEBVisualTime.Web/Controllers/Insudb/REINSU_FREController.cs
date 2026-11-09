using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REINSU_FRE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REINSU_FREController : Controller
{
    private readonly IREINSU_FREService _service;
    private readonly ITABLE97Service _TABLE97Service;

    public REINSU_FREController(IREINSU_FREService service
        , ITABLE97Service TABLE97Service
    )
    {
        _service = service;
        _TABLE97Service = TABLE97Service;
    }

    // GET: REINSU_FRE
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/REINSU_FRE/Index.cshtml");

    // GET: REINSU_FRE/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSU_FRE/Details.cshtml", result);
    }

    // GET: REINSU_FRE/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/REINSU_FRE/Create.cshtml", new CreateREINSU_FREDto());
    }

    // POST: REINSU_FRE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREINSU_FREDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/REINSU_FRE/Create.cshtml", createDto);
    }

    // GET: REINSU_FRE/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREINSU_FREDto
        {
            SBUSSITYPE = result.SBUSSITYPE,
            DEFFECDATE = result.DEFFECDATE,
            NCOMPANY = result.NCOMPANY,
            SFREE = result.SFREE,
            NTYPE_REL = result.NTYPE_REL,
            NNUMBER = result.NNUMBER,
            DCOMPDATE = result.DCOMPDATE,
            NTYPE = result.NTYPE,
            NCLAIM_AM = result.NCLAIM_AM,
            NYEAR_CONTR = result.NYEAR_CONTR,
            NPREMIUM_AM = result.NPREMIUM_AM,
            NBRANCH = result.NBRANCH,
            NCURRENCY = result.NCURRENCY,
            NTYPE_PER = result.NTYPE_PER,
            NPERIODY = result.NPERIODY,
            NUSERCODE = result.NUSERCODE,
            NYEAR = result.NYEAR,
            NYEAR_SER = result.NYEAR_SER,
        };
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/REINSU_FRE/Edit.cshtml", updateDto);
    }

    // POST: REINSU_FRE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateREINSU_FREDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE97DropdownAsync();
        return View("~/Views/Insudb/REINSU_FRE/Edit.cshtml", updateDto);
    }

    // GET: REINSU_FRE/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REINSU_FRE/Delete.cshtml", result);
    }

    // POST: REINSU_FRE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE97DropdownAsync()
    {
        var items = await _TABLE97Service.GetAllAsync();
        ViewData["NTYPE_PER"] = new SelectList(items, nameof(TABLE97Dto.NTYPE_PER), "SDESCRIPT");
    }

}
