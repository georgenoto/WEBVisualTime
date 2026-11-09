using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_SF;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8004;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_SFController : Controller
{
    private readonly ICLIENT_SFService _service;
    private readonly ITABLE8004Service _TABLE8004Service;

    public CLIENT_SFController(ICLIENT_SFService service
        , ITABLE8004Service TABLE8004Service
    )
    {
        _service = service;
        _TABLE8004Service = TABLE8004Service;
    }

    // GET: CLIENT_SF
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIENT_SF/Index.cshtml");

    // GET: CLIENT_SF/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_SF/Details.cshtml", result);
    }

    // GET: CLIENT_SF/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8004DropdownAsync();
        return View("~/Views/Insudb/CLIENT_SF/Create.cshtml", new CreateCLIENT_SFDto());
    }

    // POST: CLIENT_SF/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_SFDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8004DropdownAsync();
        return View("~/Views/Insudb/CLIENT_SF/Create.cshtml", createDto);
    }

    // GET: CLIENT_SF/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        ViewData["RecordId"] = id;
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_SFDto
        {
            SCLIENT = result.SCLIENT,
            SDIGIT = result.SDIGIT,
            NPOSITION = result.NPOSITION,
            DSTARTCONDITION = result.DSTARTCONDITION,
            DENDCONDITION = result.DENDCONDITION,
            DEFFECDATE = result.DEFFECDATE,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NPLACEBIRTH = result.NPLACEBIRTH,
            NSECOND_NATIONALITY = result.NSECOND_NATIONALITY,
            NRESIDENT_FORMER = result.NRESIDENT_FORMER,
            SUSADDRES = result.SUSADDRES,
            SUSLEGAL_PERSON = result.SUSLEGAL_PERSON,
            SUSPHONE = result.SUSPHONE,
            SUSACCOUNT = result.SUSACCOUNT,
            SSSN = result.SSSN,
            SUS_ITINNUM = result.SUS_ITINNUM,
            SUS_IRSIND = result.SUS_IRSIND,
            SPLACEBIRTH = result.SPLACEBIRTH,
            NTYPELIST = result.NTYPELIST,
        };
        await PopulateTABLE8004DropdownAsync();
        return View("~/Views/Insudb/CLIENT_SF/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_SF/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, UpdateCLIENT_SFDto updateDto)
    {
        ViewData["RecordId"] = id;
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(id, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8004DropdownAsync();
        return View("~/Views/Insudb/CLIENT_SF/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_SF/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_SF/Delete.cshtml", result);
    }

    // POST: CLIENT_SF/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8004DropdownAsync()
    {
        var items = await _TABLE8004Service.GetAllAsync();
        ViewData["NPOSITION"] = new SelectList(items, nameof(TABLE8004Dto.NTYPEPOP), "SDESCRIPT");
    }

}
