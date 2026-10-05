using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.WAY_PAY_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WAY_PAY_PRODController : Controller
{
    private readonly IWAY_PAY_PRODService _service;
    private readonly ITABLE5002Service _TABLE5002Service;
    private readonly ITABLE8215Service _TABLE8215Service;

    public WAY_PAY_PRODController(IWAY_PAY_PRODService service
        , ITABLE5002Service TABLE5002Service
        , ITABLE8215Service TABLE8215Service
    )
    {
        _service = service;
        _TABLE5002Service = TABLE5002Service;
        _TABLE8215Service = TABLE8215Service;
    }

    // GET: WAY_PAY_PROD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/WAY_PAY_PROD/Index.cshtml", result);
    }

    // GET: WAY_PAY_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WAY_PAY_PROD/Details.cshtml", result);
    }

    // GET: WAY_PAY_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE8215DropdownAsync();
        return View("~/Views/Insudb/WAY_PAY_PROD/Create.cshtml", new CreateWAY_PAY_PRODDto());
    }

    // POST: WAY_PAY_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateWAY_PAY_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE8215DropdownAsync();
        return View("~/Views/Insudb/WAY_PAY_PROD/Create.cshtml", createDto);
    }

    // GET: WAY_PAY_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateWAY_PAY_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NWAY_PAY = result.NWAY_PAY,
            DEFFECDATE = result.DEFFECDATE,
            NRATE_EX = result.NRATE_EX,
            NRATE_DISC = result.NRATE_DISC,
            SPREM_FIRST = result.SPREM_FIRST,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NNULL_DAY = result.NNULL_DAY,
            SIND_PREISSU = result.SIND_PREISSU,
            SIND_PREREF = result.SIND_PREREF,
            SONERECEIPT = result.SONERECEIPT,
            SLASTRECEIPT = result.SLASTRECEIPT,
            SCOLLECTION = result.SCOLLECTION,
            SIND_PREREFMAX = result.SIND_PREREFMAX,
            SPRFIRST_EXPR = result.SPRFIRST_EXPR,
            NTYPE_VALUECOLLECT = result.NTYPE_VALUECOLLECT,
        };
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE8215DropdownAsync();
        return View("~/Views/Insudb/WAY_PAY_PROD/Edit.cshtml", updateDto);
    }

    // POST: WAY_PAY_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateWAY_PAY_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE8215DropdownAsync();
        return View("~/Views/Insudb/WAY_PAY_PROD/Edit.cshtml", updateDto);
    }

    // GET: WAY_PAY_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/WAY_PAY_PROD/Delete.cshtml", result);
    }

    // POST: WAY_PAY_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE8215DropdownAsync()
    {
        var items = await _TABLE8215Service.GetAllAsync();
        ViewData["NTYPE_VALUECOLLECT"] = new SelectList(items, nameof(TABLE8215Dto.NTYPE_VALUECOLLECT), "SDESCRIPT");
    }

}
