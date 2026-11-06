using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_BILL_I;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_BILL_IController : Controller
{
    private readonly ITAB_BILL_IService _service;

    public TAB_BILL_IController(ITAB_BILL_IService service
    )
    {
        _service = service;
    }

    // GET: TAB_BILL_I
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/TAB_BILL_I/Index.cshtml");

    // GET: TAB_BILL_I/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_BILL_I/Details.cshtml", result);
    }

    // GET: TAB_BILL_I/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_BILL_I/Create.cshtml", new CreateTAB_BILL_IDto());
    }

    // POST: TAB_BILL_I/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_BILL_IDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_BILL_I/Create.cshtml", createDto);
    }

    // GET: TAB_BILL_I/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_BILL_IDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NBILL_ITEM = result.NBILL_ITEM,
            DEFFECDATE = result.DEFFECDATE,
            DCOMPDATE = result.DCOMPDATE,
            SDESCRIPT = result.SDESCRIPT,
            DNULLDATE = result.DNULLDATE,
            SSHORT_DES = result.SSHORT_DES,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/TAB_BILL_I/Edit.cshtml", updateDto);
    }

    // POST: TAB_BILL_I/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_BILL_IDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_BILL_I/Edit.cshtml", updateDto);
    }

    // GET: TAB_BILL_I/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_BILL_I/Delete.cshtml", result);
    }

    // POST: TAB_BILL_I/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
