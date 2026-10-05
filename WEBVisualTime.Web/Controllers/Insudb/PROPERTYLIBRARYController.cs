using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROPERTYLIBRARYController : Controller
{
    private readonly IPROPERTYLIBRARYService _service;

    public PROPERTYLIBRARYController(IPROPERTYLIBRARYService service
    )
    {
        _service = service;
    }

    // GET: PROPERTYLIBRARY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PROPERTYLIBRARY/Index.cshtml", result);
    }

    // GET: PROPERTYLIBRARY/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROPERTYLIBRARY/Details.cshtml", result);
    }

    // GET: PROPERTYLIBRARY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PROPERTYLIBRARY/Create.cshtml", new CreatePROPERTYLIBRARYDto());
    }

    // POST: PROPERTYLIBRARY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROPERTYLIBRARYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROPERTYLIBRARY/Create.cshtml", createDto);
    }

    // GET: PROPERTYLIBRARY/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROPERTYLIBRARYDto
        {
            NIDPROPERTY = result.NIDPROPERTY,
            SPROPERTY = result.SPROPERTY,
            SFORMAT = result.SFORMAT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/PROPERTYLIBRARY/Edit.cshtml", updateDto);
    }

    // POST: PROPERTYLIBRARY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROPERTYLIBRARYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPROPERTY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PROPERTYLIBRARY/Edit.cshtml", updateDto);
    }

    // GET: PROPERTYLIBRARY/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROPERTYLIBRARY/Delete.cshtml", result);
    }

    // POST: PROPERTYLIBRARY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
