using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PROD_ADDCAP;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_LIFCOV;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROD_ADDCAPController : Controller
{
    private readonly IPROD_ADDCAPService _service;
    private readonly ITAB_LIFCOVService _TAB_LIFCOVService;

    public PROD_ADDCAPController(IPROD_ADDCAPService service
        , ITAB_LIFCOVService TAB_LIFCOVService
    )
    {
        _service = service;
        _TAB_LIFCOVService = TAB_LIFCOVService;
    }

    // GET: PROD_ADDCAP
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PROD_ADDCAP/Index.cshtml", result);
    }

    // GET: PROD_ADDCAP/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_ADDCAP/Details.cshtml", result);
    }

    // GET: PROD_ADDCAP/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTAB_LIFCOVDropdownAsync();
        return View("~/Views/Insudb/PROD_ADDCAP/Create.cshtml", new CreatePROD_ADDCAPDto());
    }

    // POST: PROD_ADDCAP/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePROD_ADDCAPDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        return View("~/Views/Insudb/PROD_ADDCAP/Create.cshtml", createDto);
    }

    // GET: PROD_ADDCAP/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePROD_ADDCAPDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NCOVERGEN = result.NCOVERGEN,
            NUSERCODE = result.NUSERCODE,
            NBRANCHADD = result.NBRANCHADD,
            DCOMPDATE = result.DCOMPDATE,
            NPRODUCTADD = result.NPRODUCTADD,
            NID = result.NID,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NROLE = result.NROLE,
            NCAPITAL = result.NCAPITAL,
            NCOVERADD = result.NCOVERADD,
            NROLEADD = result.NROLEADD,
            NTYP_CUMUL = result.NTYP_CUMUL,
        };
        await PopulateTAB_LIFCOVDropdownAsync();
        return View("~/Views/Insudb/PROD_ADDCAP/Edit.cshtml", updateDto);
    }

    // POST: PROD_ADDCAP/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePROD_ADDCAPDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTAB_LIFCOVDropdownAsync();
        return View("~/Views/Insudb/PROD_ADDCAP/Edit.cshtml", updateDto);
    }

    // GET: PROD_ADDCAP/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PROD_ADDCAP/Delete.cshtml", result);
    }

    // POST: PROD_ADDCAP/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTAB_LIFCOVDropdownAsync()
    {
        var items = await _TAB_LIFCOVService.GetAllAsync();
        ViewData["NCOVERGEN"] = new SelectList(items, nameof(TAB_LIFCOVDto.NCOVERGEN), "SCACALFRI");
    }

}
