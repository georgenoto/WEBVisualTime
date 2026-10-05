using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.SEQUEN_POL;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.DTOs.WINDOWS;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SEQUEN_POLController : Controller
{
    private readonly ISEQUEN_POLService _service;
    private readonly ITABLE5588Service _TABLE5588Service;
    private readonly IWINDOWSService _WINDOWSService;

    public SEQUEN_POLController(ISEQUEN_POLService service
        , ITABLE5588Service TABLE5588Service
        , IWINDOWSService WINDOWSService
    )
    {
        _service = service;
        _TABLE5588Service = TABLE5588Service;
        _WINDOWSService = WINDOWSService;
    }

    // GET: SEQUEN_POL
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/SEQUEN_POL/Index.cshtml", result);
    }

    // GET: SEQUEN_POL/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SEQUEN_POL/Details.cshtml", result);
    }

    // GET: SEQUEN_POL/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/SEQUEN_POL/Create.cshtml", new CreateSEQUEN_POLDto());
    }

    // POST: SEQUEN_POL/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateSEQUEN_POLDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/SEQUEN_POL/Create.cshtml", createDto);
    }

    // GET: SEQUEN_POL/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateSEQUEN_POLDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            SBUSSITYP = result.SBUSSITYP,
            NTRATYPEP = result.NTRATYPEP,
            SPOLITYPE = result.SPOLITYPE,
            SCOMPON = result.SCOMPON,
            NSEQUENCE = result.NSEQUENCE,
            DEFFECDATE = result.DEFFECDATE,
            SCODISPL = result.SCODISPL,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            SREQUIRE = result.SREQUIRE,
            NUSERCODE = result.NUSERCODE,
            SAUTOMATIC = result.SAUTOMATIC,
            NTYPE_AMEND = result.NTYPE_AMEND,
        };
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/SEQUEN_POL/Edit.cshtml", updateDto);
    }

    // POST: SEQUEN_POL/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateSEQUEN_POLDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5588DropdownAsync();
        await PopulateWINDOWSDropdownAsync();
        return View("~/Views/Insudb/SEQUEN_POL/Edit.cshtml", updateDto);
    }

    // GET: SEQUEN_POL/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/SEQUEN_POL/Delete.cshtml", result);
    }

    // POST: SEQUEN_POL/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5588DropdownAsync()
    {
        var items = await _TABLE5588Service.GetAllAsync();
        ViewData["NTRATYPEP"] = new SelectList(items, nameof(TABLE5588Dto.NTRATYPEP), "SDESCRIPT");
    }

    private async Task PopulateWINDOWSDropdownAsync()
    {
        var items = await _WINDOWSService.GetAllAsync();
        ViewData["SCODISPL"] = new SelectList(items, nameof(WINDOWSDto.SCODISPL), "SCODISP");
    }

}
