using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.APV_LED_ACC;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class APV_LED_ACCController : Controller
{
    private readonly IAPV_LED_ACCService _service;

    public APV_LED_ACCController(IAPV_LED_ACCService service
    )
    {
        _service = service;
    }

    // GET: APV_LED_ACC
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/APV_LED_ACC/Index.cshtml", result);
    }

    // GET: APV_LED_ACC/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/APV_LED_ACC/Details.cshtml", result);
    }

    // GET: APV_LED_ACC/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/APV_LED_ACC/Create.cshtml", new CreateAPV_LED_ACCDto());
    }

    // POST: APV_LED_ACC/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAPV_LED_ACCDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/APV_LED_ACC/Create.cshtml", createDto);
    }

    // GET: APV_LED_ACC/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateAPV_LED_ACCDto
        {
            NTYPE_MOVE = result.NTYPE_MOVE,
            NTYP_PROFITWORKER = result.NTYP_PROFITWORKER,
            SLEDACC = result.SLEDACC,
            SDESCLED = result.SDESCLED,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
        };
        return View("~/Views/Insudb/APV_LED_ACC/Edit.cshtml", updateDto);
    }

    // POST: APV_LED_ACC/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateAPV_LED_ACCDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NTYPE_MOVE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/APV_LED_ACC/Edit.cshtml", updateDto);
    }

    // GET: APV_LED_ACC/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/APV_LED_ACC/Delete.cshtml", result);
    }

    // POST: APV_LED_ACC/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
