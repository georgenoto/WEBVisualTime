using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ROLE_TYPE_AMEND;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TYPE_AMEND;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ROLE_TYPE_AMENDController : Controller
{
    private readonly IROLE_TYPE_AMENDService _service;
    private readonly ITYPE_AMENDService _TYPE_AMENDService;

    public ROLE_TYPE_AMENDController(IROLE_TYPE_AMENDService service
        , ITYPE_AMENDService TYPE_AMENDService
    )
    {
        _service = service;
        _TYPE_AMENDService = TYPE_AMENDService;
    }

    // GET: ROLE_TYPE_AMEND
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/ROLE_TYPE_AMEND/Index.cshtml");

    // GET: ROLE_TYPE_AMEND/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Details.cshtml", result);
    }

    // GET: ROLE_TYPE_AMEND/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTYPE_AMENDDropdownAsync();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Create.cshtml", new CreateROLE_TYPE_AMENDDto());
    }

    // POST: ROLE_TYPE_AMEND/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateROLE_TYPE_AMENDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTYPE_AMENDDropdownAsync();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Create.cshtml", createDto);
    }

    // GET: ROLE_TYPE_AMEND/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateROLE_TYPE_AMENDDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            NTYPE_AMEND = result.NTYPE_AMEND,
            NROLEID = result.NROLEID,
        };
        await PopulateTYPE_AMENDDropdownAsync();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Edit.cshtml", updateDto);
    }

    // POST: ROLE_TYPE_AMEND/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateROLE_TYPE_AMENDDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTYPE_AMENDDropdownAsync();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Edit.cshtml", updateDto);
    }

    // GET: ROLE_TYPE_AMEND/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ROLE_TYPE_AMEND/Delete.cshtml", result);
    }

    // POST: ROLE_TYPE_AMEND/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTYPE_AMENDDropdownAsync()
    {
        var items = await _TYPE_AMENDService.GetAllAsync();
        ViewData["NBRANCH"] = new SelectList(items, nameof(TYPE_AMENDDto.NBRANCH), "SIND_ORDER_SERV");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(TYPE_AMENDDto.NPRODUCT), "SIND_ORDER_SERV");
        ViewData["DEFFECDATE"] = new SelectList(items, nameof(TYPE_AMENDDto.DEFFECDATE), "SIND_ORDER_SERV");
        ViewData["NTYPE_AMEND"] = new SelectList(items, nameof(TYPE_AMENDDto.NTYPE_AMEND), "SIND_ORDER_SERV");
    }

}
