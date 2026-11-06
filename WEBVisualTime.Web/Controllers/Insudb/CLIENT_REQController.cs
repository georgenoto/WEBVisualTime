using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT_REQ;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8017;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class CLIENT_REQController : Controller
{
    private readonly ICLIENT_REQService _service;
    private readonly ITABLE8017Service _TABLE8017Service;

    public CLIENT_REQController(ICLIENT_REQService service
        , ITABLE8017Service TABLE8017Service
    )
    {
        _service = service;
        _TABLE8017Service = TABLE8017Service;
    }

    // GET: CLIENT_REQ
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/CLIENT_REQ/Index.cshtml");

    // GET: CLIENT_REQ/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_REQ/Details.cshtml", result);
    }

    // GET: CLIENT_REQ/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE8017DropdownAsync();
        return View("~/Views/Insudb/CLIENT_REQ/Create.cshtml", new CreateCLIENT_REQDto());
    }

    // POST: CLIENT_REQ/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateCLIENT_REQDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8017DropdownAsync();
        return View("~/Views/Insudb/CLIENT_REQ/Create.cshtml", createDto);
    }

    // GET: CLIENT_REQ/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateCLIENT_REQDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NROLE = result.NROLE,
            NTRATYPEP = result.NTRATYPEP,
            NFIELD = result.NFIELD,
            DEFFECDATE = result.DEFFECDATE,
            SBIRTHDAI = result.SBIRTHDAI,
            SCIVISTAI = result.SCIVISTAI,
            DCOMPDATE = result.DCOMPDATE,
            DNULLDATE = result.DNULLDATE,
            SREQUIRED = result.SREQUIRED,
            SOCCUPATI = result.SOCCUPATI,
            SSEXINSUI = result.SSEXINSUI,
            NUSERCODE = result.NUSERCODE,
            STAX_SITUA = result.STAX_SITUA,
            SADDRESS = result.SADDRESS,
            SCREDITLINE = result.SCREDITLINE,
        };
        await PopulateTABLE8017DropdownAsync();
        return View("~/Views/Insudb/CLIENT_REQ/Edit.cshtml", updateDto);
    }

    // POST: CLIENT_REQ/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateCLIENT_REQDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE8017DropdownAsync();
        return View("~/Views/Insudb/CLIENT_REQ/Edit.cshtml", updateDto);
    }

    // GET: CLIENT_REQ/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/CLIENT_REQ/Delete.cshtml", result);
    }

    // POST: CLIENT_REQ/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE8017DropdownAsync()
    {
        var items = await _TABLE8017Service.GetAllAsync();
        ViewData["NFIELD"] = new SelectList(items, nameof(TABLE8017Dto.NFIELD), "SDESCRIPT");
    }

}
