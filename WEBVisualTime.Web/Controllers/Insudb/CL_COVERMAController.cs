using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_COVERMA;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CL_COVERMAController : Controller
{
    private readonly ICL_COVERMAService _service;

    public CL_COVERMAController(ICL_COVERMAService service
    )
    {
        _service = service;
    }

    // GET: CL_COVERMA
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/CL_COVERMA/Index.cshtml", result);
    }

    // GET: CL_COVERMA/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COVERMA/Details.cshtml", result);
    }

    // GET: CL_COVERMA/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CL_COVERMA/Create.cshtml", new CreateCL_COVERMADto());
    }

    // POST: CL_COVERMA/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCL_COVERMADto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_COVERMA/Create.cshtml", createDto);
    }

    // GET: CL_COVERMA/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCL_COVERMADto
        {
            NMODULEC = result.NMODULEC,
            NCOVER = result.NCOVER,
            NCONCEPT = result.NCONCEPT,
            NAMOUNT = result.NAMOUNT,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            NDED_AMOUNT = result.NDED_AMOUNT,
            NQUANT_USED = result.NQUANT_USED,
            NRESERVE = result.NRESERVE,
            NUNIT_COST = result.NUNIT_COST,
            NUSERCODE = result.NUSERCODE,
            SBUDGET = result.SBUDGET,
            DDATE_BUD = result.DDATE_BUD,
            NBILL_CON = result.NBILL_CON,
            SBILL = result.SBILL,
            DSTATRDAT = result.DSTATRDAT,
            DPAYDATE = result.DPAYDATE,
            DCANCELDAT = result.DCANCELDAT,
            NEXCHANGE = result.NEXCHANGE,
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NPROVIDER = result.NPROVIDER,
            NEVALSTAT = result.NEVALSTAT,
        };
        return View("~/Views/Insudb/CL_COVERMA/Edit.cshtml", updateDto);
    }

    // POST: CL_COVERMA/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCL_COVERMADto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMODULEC, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_COVERMA/Edit.cshtml", updateDto);
    }

    // GET: CL_COVERMA/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_COVERMA/Delete.cshtml", result);
    }

    // POST: CL_COVERMA/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
