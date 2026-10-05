using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_RESERVE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROD_RESERVEController : Controller
{
    private readonly IPROD_RESERVEService _service;

    public PROD_RESERVEController(IPROD_RESERVEService service
    )
    {
        _service = service;
    }

    // GET: PROD_RESERVE
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PROD_RESERVE/Index.cshtml", result);
    }

    // GET: PROD_RESERVE/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_RESERVE/Details.cshtml", result);
    }

    // GET: PROD_RESERVE/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PROD_RESERVE/Create.cshtml", new CreatePROD_RESERVEDto());
    }

    // POST: PROD_RESERVE/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROD_RESERVEDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROD_RESERVE/Create.cshtml", createDto);
    }

    // GET: PROD_RESERVE/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROD_RESERVEDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NTYPE_RESERVE = result.NTYPE_RESERVE,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            SROURESER = result.SROURESER,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NPERCRESER = result.NPERCRESER,
            NRESEAMO = result.NRESEAMO,
            NMAXPERCENT = result.NMAXPERCENT,
            SROUTINECOST = result.SROUTINECOST,
            SMORTALCO = result.SMORTALCO,
        };
        return View("~/Views/Insudb/PROD_RESERVE/Edit.cshtml", updateDto);
    }

    // POST: PROD_RESERVE/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROD_RESERVEDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROD_RESERVE/Edit.cshtml", updateDto);
    }

    // GET: PROD_RESERVE/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_RESERVE/Delete.cshtml", result);
    }

    // POST: PROD_RESERVE/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
