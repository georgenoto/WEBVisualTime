using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_PRODUCTION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BOOK_PRODUCTIONController : Controller
{
    private readonly IBOOK_PRODUCTIONService _service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly ITABLE5555Service _TABLE5555Service;
    private readonly ITABLE24Service _TABLE24Service;
    private readonly ITABLE6Service _TABLE6Service;

    public BOOK_PRODUCTIONController(IBOOK_PRODUCTIONService service
        , ITABLE9Service TABLE9Service
        , ITABLE5556Service TABLE5556Service
        , ITABLE5555Service TABLE5555Service
        , ITABLE24Service TABLE24Service
        , ITABLE6Service TABLE6Service
    )
    {
        _service = service;
        _TABLE9Service = TABLE9Service;
        _TABLE5556Service = TABLE5556Service;
        _TABLE5555Service = TABLE5555Service;
        _TABLE24Service = TABLE24Service;
        _TABLE6Service = TABLE6Service;
    }

    // GET: BOOK_PRODUCTION
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Index.cshtml", result);
    }

    // GET: BOOK_PRODUCTION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Details.cshtml", result);
    }

    // GET: BOOK_PRODUCTION/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Create.cshtml", new CreateBOOK_PRODUCTIONDto());
    }

    // POST: BOOK_PRODUCTION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBOOK_PRODUCTIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Create.cshtml", createDto);
    }

    // GET: BOOK_PRODUCTION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBOOK_PRODUCTIONDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NRECEIPT = result.NRECEIPT,
            NTRANSAC = result.NTRANSAC,
            SKEY = result.SKEY,
            SCLIENTSPONSOR = result.SCLIENTSPONSOR,
            DSTARTDATE = result.DSTARTDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NCERTIF = result.NCERTIF,
            DDATE_ACCEPT = result.DDATE_ACCEPT,
            SCLIENT_ASEG = result.SCLIENT_ASEG,
            NCURRENCY = result.NCURRENCY,
            NPREMIUME_MO = result.NPREMIUME_MO,
            NPREMIUMA_MO = result.NPREMIUMA_MO,
            NPREMIUM_MO = result.NPREMIUM_MO,
            NPREMIUME = result.NPREMIUME,
            NPREMIUMA = result.NPREMIUMA,
            SCLIENT_AGEN = result.SCLIENT_AGEN,
            NPREMIUM = result.NPREMIUM,
            NCOMAMOU_MO = result.NCOMAMOU_MO,
            NCOMAMOU_PES = result.NCOMAMOU_PES,
            DPOSTED = result.DPOSTED,
            NBRANCH_LED = result.NBRANCH_LED,
            NCOMPANY = result.NCOMPANY,
            NINSUR_AREA = result.NINSUR_AREA,
            DSTARTDATE_REP = result.DSTARTDATE_REP,
            DEXPIRDATE_REP = result.DEXPIRDATE_REP,
            NOFFICE = result.NOFFICE,
            NPROPONUM = result.NPROPONUM,
            DLEDGERDAT = result.DLEDGERDAT,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            NTRATYPEI = result.NTRATYPEI,
            NTYPE = result.NTYPE,
            NTYPE_TRAN = result.NTYPE_TRAN,
            NTAXAMOUNT_MO = result.NTAXAMOUNT_MO,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NACCCRITERION = result.NACCCRITERION,
        };
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Edit.cshtml", updateDto);
    }

    // POST: BOOK_PRODUCTION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBOOK_PRODUCTIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Edit.cshtml", updateDto);
    }

    // GET: BOOK_PRODUCTION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BOOK_PRODUCTION/Delete.cshtml", result);
    }

    // POST: BOOK_PRODUCTION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5556DropdownAsync()
    {
        var items = await _TABLE5556Service.GetAllAsync();
        ViewData["NOFFICEAGEN"] = new SelectList(items, nameof(TABLE5556Dto.NOFFICEAGEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
    }

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE_TRAN"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

}
