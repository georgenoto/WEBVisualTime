using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class NOCONVERSController : Controller
{
    private readonly INOCONVERSService _service;
    private readonly ITABLE5603Service _TABLE5603Service;

    public NOCONVERSController(INOCONVERSService service
        , ITABLE5603Service TABLE5603Service
    )
    {
        _service = service;
        _TABLE5603Service = TABLE5603Service;
    }

    // GET: NOCONVERS
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/NOCONVERS/Index.cshtml", result);
    }

    // GET: NOCONVERS/Details/{id}
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOCONVERS/Details.cshtml", result);
    }

    // GET: NOCONVERS/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/NOCONVERS/Create.cshtml", new CreateNOCONVERSDto());
    }

    // POST: NOCONVERS/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateNOCONVERSDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/NOCONVERS/Create.cshtml", createDto);
    }

    // GET: NOCONVERS/Edit/{id}
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateNOCONVERSDto
        {
            NNO_CONVERS = result.NNO_CONVERS,
            SDESCRIPT = result.SDESCRIPT,
            NAREAWAIT = result.NAREAWAIT,
            SDEVO = result.SDEVO,
            SDISC = result.SDISC,
            SSTATREGT = result.SSTATREGT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NEXPENSES = result.NEXPENSES,
            SROUTINE = result.SROUTINE,
            NHEALTHEXP = result.NHEALTHEXP,
        };
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/NOCONVERS/Edit.cshtml", updateDto);
    }

    // POST: NOCONVERS/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateNOCONVERSDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NNO_CONVERS, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE5603DropdownAsync();
        return View("~/Views/Insudb/NOCONVERS/Edit.cshtml", updateDto);
    }

    // GET: NOCONVERS/Delete/{id}
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/NOCONVERS/Delete.cshtml", result);
    }

    // POST: NOCONVERS/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE5603DropdownAsync()
    {
        var items = await _TABLE5603Service.GetAllAsync();
        ViewData["NAREAWAIT"] = new SelectList(items, nameof(TABLE5603Dto.NAREAWAIT), "SDESCRIPT");
    }

}
