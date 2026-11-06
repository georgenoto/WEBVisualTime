using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DETAIL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9261;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASTERCL_DETAILController : Controller
{
    private readonly IMASTERCL_DETAILService _service;
    private readonly ITABLE9261Service _TABLE9261Service;
    private readonly ITABLE9271Service _TABLE9271Service;

    public MASTERCL_DETAILController(IMASTERCL_DETAILService service
        , ITABLE9261Service TABLE9261Service
        , ITABLE9271Service TABLE9271Service
    )
    {
        _service = service;
        _TABLE9261Service = TABLE9261Service;
        _TABLE9271Service = TABLE9271Service;
    }

    // GET: MASTERCL_DETAIL
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/MASTERCL_DETAIL/Index.cshtml");

    // GET: MASTERCL_DETAIL/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Details.cshtml", result);
    }

    // GET: MASTERCL_DETAIL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9261DropdownAsync();
        await PopulateTABLE9271DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Create.cshtml", new CreateMASTERCL_DETAILDto());
    }

    // POST: MASTERCL_DETAIL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASTERCL_DETAILDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9261DropdownAsync();
        await PopulateTABLE9271DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Create.cshtml", createDto);
    }

    // GET: MASTERCL_DETAIL/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASTERCL_DETAILDto
        {
            NMASTERORDER = result.NMASTERORDER,
            NORD_PROCEDURE = result.NORD_PROCEDURE,
            NID = result.NID,
            SBENEFIT = result.SBENEFIT,
            SSAME_INCISION = result.SSAME_INCISION,
            NPERCENTAGE_PROC = result.NPERCENTAGE_PROC,
            SILLNESS = result.SILLNESS,
            NCOD_REJECT = result.NCOD_REJECT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SREJECTALERT = result.SREJECTALERT,
            NAPPLY_EXCLU = result.NAPPLY_EXCLU,
            SILLNES_DETECT = result.SILLNES_DETECT,
            NACCEPT_EVALMED = result.NACCEPT_EVALMED,
            SMEDICAL_REJEC = result.SMEDICAL_REJEC,
            SREJECTOBSV = result.SREJECTOBSV,
            NORDER_NUM = result.NORDER_NUM,
            NPROCEDURE_ID = result.NPROCEDURE_ID,
            NRELPROCEDURE_ID = result.NRELPROCEDURE_ID,
            NBALANCE = result.NBALANCE,
            NAMOUNT_DOCU = result.NAMOUNT_DOCU,
            NAMOUNT_ORDEN = result.NAMOUNT_ORDEN,
            NPERCEN_COVERAGE = result.NPERCEN_COVERAGE,
            NQUANTITY = result.NQUANTITY,
            NIND_DONOTRECALCULATE = result.NIND_DONOTRECALCULATE,
            NAMOUNT_DIFFERENCETARIFF = result.NAMOUNT_DIFFERENCETARIFF,
            NIND_REOPENCL = result.NIND_REOPENCL,
            NCAUSEREOPENCL = result.NCAUSEREOPENCL,
            NTYPE_COMMPAY = result.NTYPE_COMMPAY,
            NRELPROCEDURE_NUM_ORIG = result.NRELPROCEDURE_NUM_ORIG,
            NRELPROCEDURE_NUM_GEN = result.NRELPROCEDURE_NUM_GEN,
        };
        await PopulateTABLE9261DropdownAsync();
        await PopulateTABLE9271DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Edit.cshtml", updateDto);
    }

    // POST: MASTERCL_DETAIL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASTERCL_DETAILDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NMASTERORDER, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9261DropdownAsync();
        await PopulateTABLE9271DropdownAsync();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Edit.cshtml", updateDto);
    }

    // GET: MASTERCL_DETAIL/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASTERCL_DETAIL/Delete.cshtml", result);
    }

    // POST: MASTERCL_DETAIL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9261DropdownAsync()
    {
        var items = await _TABLE9261Service.GetAllAsync();
        ViewData["NORD_PROCEDURE"] = new SelectList(items, nameof(TABLE9261Dto.NORD_PROCEDURE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9271DropdownAsync()
    {
        var items = await _TABLE9271Service.GetAllAsync();
        ViewData["NCAUSEREOPENCL"] = new SelectList(items, nameof(TABLE9271Dto.NCAUSEREOPENCL), "SDESCRIPT");
    }

}
