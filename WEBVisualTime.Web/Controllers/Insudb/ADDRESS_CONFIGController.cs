using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ADDRESS_CONFIGController : Controller
{
    private readonly IADDRESS_CONFIGService _service;

    public ADDRESS_CONFIGController(IADDRESS_CONFIGService service
    )
    {
        _service = service;
    }

    // GET: ADDRESS_CONFIG
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ADDRESS_CONFIG/Index.cshtml", result);
    }

    // GET: ADDRESS_CONFIG/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ADDRESS_CONFIG/Details.cshtml", result);
    }

    // GET: ADDRESS_CONFIG/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/ADDRESS_CONFIG/Create.cshtml", new CreateADDRESS_CONFIGDto());
    }

    // POST: ADDRESS_CONFIG/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateADDRESS_CONFIGDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ADDRESS_CONFIG/Create.cshtml", createDto);
    }

    // GET: ADDRESS_CONFIG/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateADDRESS_CONFIGDto
        {
            COUNTRY = result.COUNTRY,
            ADDRESS_SETTINGS = result.ADDRESS_SETTINGS,
            PHONE_SETTINGS = result.PHONE_SETTINGS,
            NUSERCODE = result.NUSERCODE,
            UPDATEDATE = result.UPDATEDATE,
        };
        return View("~/Views/Insudb/ADDRESS_CONFIG/Edit.cshtml", updateDto);
    }

    // POST: ADDRESS_CONFIG/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateADDRESS_CONFIGDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.COUNTRY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/ADDRESS_CONFIG/Edit.cshtml", updateDto);
    }

    // GET: ADDRESS_CONFIG/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ADDRESS_CONFIG/Delete.cshtml", result);
    }

    // POST: ADDRESS_CONFIG/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
