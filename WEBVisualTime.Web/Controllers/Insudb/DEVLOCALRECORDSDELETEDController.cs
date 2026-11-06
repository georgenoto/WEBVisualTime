using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DEVLOCALRECORDSDELETED;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DEVLOCALRECORDSDELETEDController : Controller
{
    private readonly IDEVLOCALRECORDSDELETEDService _service;

    public DEVLOCALRECORDSDELETEDController(IDEVLOCALRECORDSDELETEDService service
    )
    {
        _service = service;
    }

    // GET: DEVLOCALRECORDSDELETED
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/DEVLOCALRECORDSDELETED/Index.cshtml");

    // GET: DEVLOCALRECORDSDELETED/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Details.cshtml", result);
    }

    // GET: DEVLOCALRECORDSDELETED/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Create.cshtml", new CreateDEVLOCALRECORDSDELETEDDto());
    }

    // POST: DEVLOCALRECORDSDELETED/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDEVLOCALRECORDSDELETEDDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Create.cshtml", createDto);
    }

    // GET: DEVLOCALRECORDSDELETED/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDEVLOCALRECORDSDELETEDDto
        {
            LOCALRECDELID = result.LOCALRECDELID,
            NAME = result.NAME,
            DELDATE = result.DELDATE,
            PKEY = result.PKEY,
            LOCALTABLEID = result.LOCALTABLEID,
        };
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Edit.cshtml", updateDto);
    }

    // POST: DEVLOCALRECORDSDELETED/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDEVLOCALRECORDSDELETEDDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.LOCALRECDELID, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Edit.cshtml", updateDto);
    }

    // GET: DEVLOCALRECORDSDELETED/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DEVLOCALRECORDSDELETED/Delete.cshtml", result);
    }

    // POST: DEVLOCALRECORDSDELETED/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
