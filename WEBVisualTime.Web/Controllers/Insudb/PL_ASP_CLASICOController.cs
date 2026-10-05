using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PL_ASP_CLASICO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PL_ASP_CLASICOController : Controller
{
    private readonly IPL_ASP_CLASICOService _service;

    public PL_ASP_CLASICOController(IPL_ASP_CLASICOService service
    )
    {
        _service = service;
    }

    // GET: PL_ASP_CLASICO
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PL_ASP_CLASICO/Index.cshtml", result);
    }

    // GET: PL_ASP_CLASICO/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PL_ASP_CLASICO/Details.cshtml", result);
    }

    // GET: PL_ASP_CLASICO/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/PL_ASP_CLASICO/Create.cshtml", new CreatePL_ASP_CLASICODto());
    }

    // POST: PL_ASP_CLASICO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePL_ASP_CLASICODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PL_ASP_CLASICO/Create.cshtml", createDto);
    }

    // GET: PL_ASP_CLASICO/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePL_ASP_CLASICODto
        {
            NIDPROPERTY = result.NIDPROPERTY,
            SPROPERTY = result.SPROPERTY,
            SFORMAT = result.SFORMAT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
        };
        return View("~/Views/Insudb/PL_ASP_CLASICO/Edit.cshtml", updateDto);
    }

    // POST: PL_ASP_CLASICO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePL_ASP_CLASICODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NIDPROPERTY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/PL_ASP_CLASICO/Edit.cshtml", updateDto);
    }

    // GET: PL_ASP_CLASICO/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PL_ASP_CLASICO/Delete.cshtml", result);
    }

    // POST: PL_ASP_CLASICO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
