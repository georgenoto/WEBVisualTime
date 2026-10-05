using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_TABLESController : Controller
{
    private readonly ITAB_TABLESService _service;

    public TAB_TABLESController(ITAB_TABLESService service
    )
    {
        _service = service;
    }

    // GET: TAB_TABLES
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/TAB_TABLES/Index.cshtml", result);
    }

    // GET: TAB_TABLES/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_TABLES/Details.cshtml", result);
    }

    // GET: TAB_TABLES/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/TAB_TABLES/Create.cshtml", new CreateTAB_TABLESDto());
    }

    // POST: TAB_TABLES/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateTAB_TABLESDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_TABLES/Create.cshtml", createDto);
    }

    // GET: TAB_TABLES/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateTAB_TABLESDto
        {
            STAB_CODE = result.STAB_CODE,
            NCOUNT_ITEM = result.NCOUNT_ITEM,
            SCODE_ITEM = result.SCODE_ITEM,
            SDESC_ITEM = result.SDESC_ITEM,
            NCOUNT_TABL = result.NCOUNT_TABL,
            SDESCRIPT = result.SDESCRIPT,
            SDS_SELECT = result.SDS_SELECT,
            SQ_VALUE = result.SQ_VALUE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SSHOWNUM = result.SSHOWNUM,
            SINITQUERY = result.SINITQUERY,
            SINDSP = result.SINDSP,
            SKEY = result.SKEY,
        };
        return View("~/Views/Insudb/TAB_TABLES/Edit.cshtml", updateDto);
    }

    // POST: TAB_TABLES/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateTAB_TABLESDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.STAB_CODE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/TAB_TABLES/Edit.cshtml", updateDto);
    }

    // GET: TAB_TABLES/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/TAB_TABLES/Delete.cshtml", result);
    }

    // POST: TAB_TABLES/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
