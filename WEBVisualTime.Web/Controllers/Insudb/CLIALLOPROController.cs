using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIALLOPRO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIALLOPROController : Controller
{
    private readonly ICLIALLOPROService _service;

    public CLIALLOPROController(ICLIALLOPROService service
    )
    {
        _service = service;
    }

    // GET: CLIALLOPRO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIALLOPRO/Index.cshtml");

    // GET: CLIALLOPRO/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIALLOPRO/Details.cshtml", result);
    }

    // GET: CLIALLOPRO/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CLIALLOPRO/Create.cshtml", new CreateCLIALLOPRODto());
    }

    // POST: CLIALLOPRO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIALLOPRODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIALLOPRO/Create.cshtml", createDto);
    }

    // GET: CLIALLOPRO/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIALLOPRODto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SPOLITYPE = result.SPOLITYPE,
            SCOMPON = result.SCOMPON,
            NROLE = result.NROLE,
            DCOMPDATE = result.DCOMPDATE,
            SDEFAULTI = result.SDEFAULTI,
            SREQUIRE = result.SREQUIRE,
            NMAX_ROLE = result.NMAX_ROLE,
            NUSERCODE = result.NUSERCODE,
            SOPTIONALQUO = result.SOPTIONALQUO,
            DDATE_NROLE = result.DDATE_NROLE,
            NINTERMED = result.NINTERMED,
            NCONTRAT_PAY = result.NCONTRAT_PAY,
            SCLIENT = result.SCLIENT,
            SINSURABLE = result.SINSURABLE,
        };
        return View("~/Views/Insudb/CLIALLOPRO/Edit.cshtml", updateDto);
    }

    // POST: CLIALLOPRO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIALLOPRODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CLIALLOPRO/Edit.cshtml", updateDto);
    }

    // GET: CLIALLOPRO/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIALLOPRO/Delete.cshtml", result);
    }

    // POST: CLIALLOPRO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
