using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_NET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PL_ASP_NETController : Controller
{
    private readonly IPL_ASP_NETService _service;

    public PL_ASP_NETController(IPL_ASP_NETService service
    )
    {
        _service = service;
    }

    // GET: PL_ASP_NET
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PL_ASP_NET/Index.cshtml", result);
    }

    // GET: PL_ASP_NET/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PL_ASP_NET/Details.cshtml", result);
    }

    // GET: PL_ASP_NET/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PL_ASP_NET/Create.cshtml", new CreatePL_ASP_NETDto());
    }

    // POST: PL_ASP_NET/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePL_ASP_NETDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PL_ASP_NET/Create.cshtml", createDto);
    }

    // GET: PL_ASP_NET/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePL_ASP_NETDto
        {
            NIDPROPERTY = result.NIDPROPERTY,
            SPROPERTY = result.SPROPERTY,
            SFORMAT = result.SFORMAT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/PL_ASP_NET/Edit.cshtml", updateDto);
    }

    // POST: PL_ASP_NET/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePL_ASP_NETDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPROPERTY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PL_ASP_NET/Edit.cshtml", updateDto);
    }

    // GET: PL_ASP_NET/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PL_ASP_NET/Delete.cshtml", result);
    }

    // POST: PL_ASP_NET/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
