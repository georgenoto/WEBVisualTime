using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.LED_COMPAN;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class LED_COMPANController : Controller
{
    private readonly ILED_COMPANService _service;

    public LED_COMPANController(ILED_COMPANService service
    )
    {
        _service = service;
    }

    // GET: LED_COMPAN
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/LED_COMPAN/Index.cshtml", result);
    }

    // GET: LED_COMPAN/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LED_COMPAN/Details.cshtml", result);
    }

    // GET: LED_COMPAN/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/LED_COMPAN/Create.cshtml", new CreateLED_COMPANDto());
    }

    // POST: LED_COMPAN/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateLED_COMPANDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LED_COMPAN/Create.cshtml", createDto);
    }

    // GET: LED_COMPAN/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateLED_COMPANDto
        {
            NLED_COMPAN = result.NLED_COMPAN,
            SACCOUNT_BG = result.SACCOUNT_BG,
            SACCOUNT_GP = result.SACCOUNT_GP,
            SBAL_ACTU = result.SBAL_ACTU,
            SCLOSE_MONT = result.SCLOSE_MONT,
            SSTATREGT = result.SSTATREGT,
            SSTRUCT_UNI = result.SSTRUCT_UNI,
            SSTRUCTURE = result.SSTRUCTURE,
            DCOMPAN_DAT = result.DCOMPAN_DAT,
            DCOMPDATE = result.DCOMPDATE,
            DDATE_END = result.DDATE_END,
            DDATE_INIT = result.DDATE_INIT,
            NVOUCHER = result.NVOUCHER,
            NCURRENCY = result.NCURRENCY,
            NUSERCODE = result.NUSERCODE,
            NYEAR = result.NYEAR,
            DINILEDDAT = result.DINILEDDAT,
            DENDLEDDAT = result.DENDLEDDAT,
        };
        return View("~/Views/Insudb/LED_COMPAN/Edit.cshtml", updateDto);
    }

    // POST: LED_COMPAN/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateLED_COMPANDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NLED_COMPAN, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/LED_COMPAN/Edit.cshtml", updateDto);
    }

    // GET: LED_COMPAN/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/LED_COMPAN/Delete.cshtml", result);
    }

    // POST: LED_COMPAN/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
