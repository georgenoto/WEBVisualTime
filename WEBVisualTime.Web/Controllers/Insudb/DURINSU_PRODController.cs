using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.DURINSU_PROD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DURINSU_PRODController : Controller
{
    private readonly IDURINSU_PRODService _service;
    private readonly ITABLE5589Service _TABLE5589Service;

    public DURINSU_PRODController(IDURINSU_PRODService service
        , ITABLE5589Service TABLE5589Service
    )
    {
        _service = service;
        _TABLE5589Service = TABLE5589Service;
    }

    // GET: DURINSU_PROD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/DURINSU_PROD/Index.cshtml", result);
    }

    // GET: DURINSU_PROD/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DURINSU_PROD/Details.cshtml", result);
    }

    // GET: DURINSU_PROD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURINSU_PROD/Create.cshtml", new CreateDURINSU_PRODDto());
    }

    // POST: DURINSU_PROD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateDURINSU_PRODDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURINSU_PROD/Create.cshtml", createDto);
    }

    // GET: DURINSU_PROD/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateDURINSU_PRODDto
        {
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            DEFFECDATE = result.DEFFECDATE,
            NIDURAFIX = result.NIDURAFIX,
            DNULLDATE = result.DNULLDATE,
            NUSERCODE = result.NUSERCODE,
            DCOMPDATE = result.DCOMPDATE,
            NTYPDURINS = result.NTYPDURINS,
            NMINDURINS = result.NMINDURINS,
        };
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURINSU_PROD/Edit.cshtml", updateDto);
    }

    // POST: DURINSU_PROD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateDURINSU_PRODDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NBRANCH, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5589DropdownAsync();
        return View("~/Views/Insudb/DURINSU_PROD/Edit.cshtml", updateDto);
    }

    // GET: DURINSU_PROD/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/DURINSU_PROD/Delete.cshtml", result);
    }

    // POST: DURINSU_PROD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5589DropdownAsync()
    {
        var items = await _TABLE5589Service.GetAllAsync();
        ViewData["NTYPDURINS"] = new SelectList(items, nameof(TABLE5589Dto.NTYPDUR), "SDESCRIPT");
    }

}
