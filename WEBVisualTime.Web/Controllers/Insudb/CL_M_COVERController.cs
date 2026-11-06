using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CL_M_COVER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CL_M_COVERController : Controller
{
    private readonly ICL_M_COVERService _service;

    public CL_M_COVERController(ICL_M_COVERService service
    )
    {
        _service = service;
    }

    // GET: CL_M_COVER
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CL_M_COVER/Index.cshtml");

    // GET: CL_M_COVER/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_M_COVER/Details.cshtml", result);
    }

    // GET: CL_M_COVER/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/CL_M_COVER/Create.cshtml", new CreateCL_M_COVERDto());
    }

    // POST: CL_M_COVER/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCL_M_COVERDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_M_COVER/Create.cshtml", createDto);
    }

    // GET: CL_M_COVER/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCL_M_COVERDto
        {
            NCLAIM = result.NCLAIM,
            NCASE_NUM = result.NCASE_NUM,
            NDEMAN_TYPE = result.NDEMAN_TYPE,
            NTRANSAC = result.NTRANSAC,
            NCOVER = result.NCOVER,
            NMODULEC = result.NMODULEC,
            NCURRENCY = result.NCURRENCY,
            NAMOUNT = result.NAMOUNT,
            SCLIENT = result.SCLIENT,
            SAUT_ADJUST = result.SAUT_ADJUST,
            DCOMPDATE = result.DCOMPDATE,
            NDED_AMOUNT = result.NDED_AMOUNT,
            NEXCHANGE = result.NEXCHANGE,
            NEXP_AMOUNT = result.NEXP_AMOUNT,
            NGROUP = result.NGROUP,
            NLOC_AMOUNT = result.NLOC_AMOUNT,
            NQUANTITY = result.NQUANTITY,
            NUSERCODE = result.NUSERCODE,
            NVA_TAX = result.NVA_TAX,
            NVAT_AMOUNT = result.NVAT_AMOUNT,
            NLOC_COS_RE = result.NLOC_COS_RE,
            SCESCATAS = result.SCESCATAS,
            NSETTLECODE = result.NSETTLECODE,
            SPOSTEDSEQUENCE = result.SPOSTEDSEQUENCE,
        };
        return View("~/Views/Insudb/CL_M_COVER/Edit.cshtml", updateDto);
    }

    // POST: CL_M_COVER/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCL_M_COVERDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NCLAIM, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/CL_M_COVER/Edit.cshtml", updateDto);
    }

    // GET: CL_M_COVER/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CL_M_COVER/Delete.cshtml", result);
    }

    // POST: CL_M_COVER/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
