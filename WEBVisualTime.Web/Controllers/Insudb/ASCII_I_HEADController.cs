using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.ASCII_I_HEAD;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ASCII_I_HEADController : Controller
{
    private readonly IASCII_I_HEADService _service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ITABLE293Service _TABLE293Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE193Service _TABLE193Service;

    public ASCII_I_HEADController(IASCII_I_HEADService service
        , ITABLE7Service TABLE7Service
        , ITABLE293Service TABLE293Service
        , ITABLE9Service TABLE9Service
        , ITABLE193Service TABLE193Service
    )
    {
        _service = service;
        _TABLE7Service = TABLE7Service;
        _TABLE293Service = TABLE293Service;
        _TABLE9Service = TABLE9Service;
        _TABLE193Service = TABLE193Service;
    }

    // GET: ASCII_I_HEAD
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/ASCII_I_HEAD/Index.cshtml", result);
    }

    // GET: ASCII_I_HEAD/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ASCII_I_HEAD/Details.cshtml", result);
    }

    // GET: ASCII_I_HEAD/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_HEAD/Create.cshtml", new CreateASCII_I_HEADDto());
    }

    // POST: ASCII_I_HEAD/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateASCII_I_HEADDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_HEAD/Create.cshtml", createDto);
    }

    // GET: ASCII_I_HEAD/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateASCII_I_HEADDto
        {
            SASCII_NAME = result.SASCII_NAME,
            NBANK_CODE = result.NBANK_CODE,
            NCONCEPT = result.NCONCEPT,
            DSTAT_DATE = result.DSTAT_DATE,
            SACC_NUMBER = result.SACC_NUMBER,
            NAGENCY = result.NAGENCY,
            SSTATMOV = result.SSTATMOV,
            DCOMPDATE = result.DCOMPDATE,
            SSTATREGT = result.SSTATREGT,
            NUSERCODE = result.NUSERCODE,
            SPAY_FORM = result.SPAY_FORM,
        };
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_HEAD/Edit.cshtml", updateDto);
    }

    // POST: ASCII_I_HEAD/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateASCII_I_HEADDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SASCII_NAME, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE7DropdownAsync();
        await PopulateTABLE293DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE193DropdownAsync();
        return View("~/Views/Insudb/ASCII_I_HEAD/Edit.cshtml", updateDto);
    }

    // GET: ASCII_I_HEAD/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/ASCII_I_HEAD/Delete.cshtml", result);
    }

    // POST: ASCII_I_HEAD/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: ASCII_I_HEAD/GetByNBANK_CODE?NBANK_CODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNBANK_CODE(long NBANK_CODE)
    {
        var items = await _service.FindAsync(p => p.NBANK_CODE == NBANK_CODE);
        return Json(items.Select(i => new { value = i.SASCII_NAME, text = i.SACC_NUMBER }));
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE293DropdownAsync()
    {
        var items = await _TABLE293Service.GetAllAsync();
        ViewData["NCONCEPT"] = new SelectList(items, nameof(TABLE293Dto.NCONCEPT), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE193DropdownAsync()
    {
        var items = await _TABLE193Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE193Dto.SREQUEST_TY), "SDESCRIPT");
    }

}
