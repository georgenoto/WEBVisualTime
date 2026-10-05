using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.FREQ_WAY_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class FREQ_WAY_PRODController : Controller
{
    private readonly IFREQ_WAY_PRODService _service;
    private readonly ITABLE5002Service _TABLE5002Service;
    private readonly ITABLE36Service _TABLE36Service;

    public FREQ_WAY_PRODController(IFREQ_WAY_PRODService service
        , ITABLE5002Service TABLE5002Service
        , ITABLE36Service TABLE36Service
    )
    {
        _service = service;
        _TABLE5002Service = TABLE5002Service;
        _TABLE36Service = TABLE36Service;
    }

    // GET: FREQ_WAY_PROD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Index.cshtml", result);
    }

    // GET: FREQ_WAY_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Details.cshtml", result);
    }

    // GET: FREQ_WAY_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Create.cshtml", new CreateFREQ_WAY_PRODDto());
    }

    // POST: FREQ_WAY_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateFREQ_WAY_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Create.cshtml", createDto);
    }

    // GET: FREQ_WAY_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateFREQ_WAY_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NWAY_PAY = result.NWAY_PAY,
            NPAYFREQ = result.NPAYFREQ,
            DEFFECDATE = result.DEFFECDATE,
            NCURRENCY = result.NCURRENCY,
            NPRE_ISSUE = result.NPRE_ISSUE,
            NPRE_AMEND = result.NPRE_AMEND,
            DNULLDATE = result.DNULLDATE,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NLIMIT_EXCTAX = result.NLIMIT_EXCTAX,
            NQPREM_BAS_ANN = result.NQPREM_BAS_ANN,
            SIVA_COVER_IND = result.SIVA_COVER_IND,
            SNO_SELL = result.SNO_SELL,
            NPRE_COVEREXT = result.NPRE_COVEREXT,
            NPRE_ISSUEMAX = result.NPRE_ISSUEMAX,
            NDISC_PAYMETH = result.NDISC_PAYMETH,
        };
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Edit.cshtml", updateDto);
    }

    // POST: FREQ_WAY_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateFREQ_WAY_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE36DropdownAsync();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Edit.cshtml", updateDto);
    }

    // GET: FREQ_WAY_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/FREQ_WAY_PROD/Delete.cshtml", result);
    }

    // POST: FREQ_WAY_PROD/Delete/{id}
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

    private async Task PopulateTABLE36DropdownAsync()
    {
        var items = await _TABLE36Service.GetAllAsync();
        ViewData["NPAYFREQ"] = new SelectList(items, nameof(TABLE36Dto.NPAYFREQ), "SDESCRIPT");
    }

}
