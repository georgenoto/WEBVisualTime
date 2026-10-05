using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.POLICY_WIN_BACKUP_254176;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class POLICY_WIN_BACKUP_254176Controller : Controller
{
    private readonly IPOLICY_WIN_BACKUP_254176Service _service;

    public POLICY_WIN_BACKUP_254176Controller(IPOLICY_WIN_BACKUP_254176Service service
    )
    {
        _service = service;
    }

    // GET: POLICY_WIN_BACKUP_254176
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Index.cshtml", result);
    }

    // GET: POLICY_WIN_BACKUP_254176/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Details.cshtml", result);
    }

    // GET: POLICY_WIN_BACKUP_254176/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Create.cshtml", new CreatePOLICY_WIN_BACKUP_254176Dto());
    }

    // POST: POLICY_WIN_BACKUP_254176/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePOLICY_WIN_BACKUP_254176Dto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Create.cshtml", createDto);
    }

    // GET: POLICY_WIN_BACKUP_254176/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePOLICY_WIN_BACKUP_254176Dto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            SV_CONPOLIC = result.SV_CONPOLIC,
            SV_WINPOLIC = result.SV_WINPOLIC,
        };
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Edit.cshtml", updateDto);
    }

    // POST: POLICY_WIN_BACKUP_254176/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePOLICY_WIN_BACKUP_254176Dto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Edit.cshtml", updateDto);
    }

    // GET: POLICY_WIN_BACKUP_254176/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/POLICY_WIN_BACKUP_254176/Delete.cshtml", result);
    }

    // POST: POLICY_WIN_BACKUP_254176/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
