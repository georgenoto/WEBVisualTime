using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.BOOK_COLLECTION;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class BOOK_COLLECTIONController : Controller
{
    private readonly IBOOK_COLLECTIONService _service;
    private readonly ITABLE24Service _TABLE24Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE5556Service _TABLE5556Service;
    private readonly ITABLE5555Service _TABLE5555Service;
    private readonly ITABLE6Service _TABLE6Service;

    public BOOK_COLLECTIONController(IBOOK_COLLECTIONService service
        , ITABLE24Service TABLE24Service
        , ITABLE9Service TABLE9Service
        , ITABLE5556Service TABLE5556Service
        , ITABLE5555Service TABLE5555Service
        , ITABLE6Service TABLE6Service
    )
    {
        _service = service;
        _TABLE24Service = TABLE24Service;
        _TABLE9Service = TABLE9Service;
        _TABLE5556Service = TABLE5556Service;
        _TABLE5555Service = TABLE5555Service;
        _TABLE6Service = TABLE6Service;
    }

    // GET: BOOK_COLLECTION
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/BOOK_COLLECTION/Index.cshtml");

    // GET: BOOK_COLLECTION/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BOOK_COLLECTION/Details.cshtml", result);
    }

    // GET: BOOK_COLLECTION/Create
    public async Task<IActionResult> Create()
    {
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_COLLECTION/Create.cshtml", new CreateBOOK_COLLECTIONDto());
    }

    // POST: BOOK_COLLECTION/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateBOOK_COLLECTIONDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_COLLECTION/Create.cshtml", createDto);
    }

    // GET: BOOK_COLLECTION/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateBOOK_COLLECTIONDto
        {
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            NRECEIPT = result.NRECEIPT,
            NBRANCH_LED = result.NBRANCH_LED,
            NTRANSAC = result.NTRANSAC,
            SKEY = result.SKEY,
            NEXCHANGE = result.NEXCHANGE,
            NBORDEREAUX = result.NBORDEREAUX,
            NTRATYPEI = result.NTRATYPEI,
            DCOLLECTION = result.DCOLLECTION,
            DEFFECDATE = result.DEFFECDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            NTYPE = result.NTYPE,
            NCONTRAT = result.NCONTRAT,
            NDRAFT = result.NDRAFT,
            NINTEREST = result.NINTEREST,
            NINTAMMOU_AFE = result.NINTAMMOU_AFE,
            NINTAMMOU_IVA = result.NINTAMMOU_IVA,
            DVALUEDATE = result.DVALUEDATE,
            DPOSTED = result.DPOSTED,
            NWAY_PAY = result.NWAY_PAY,
            NCURRENCY = result.NCURRENCY,
            NOFFICE = result.NOFFICE,
            NOFFICEAGEN = result.NOFFICEAGEN,
            NAGENCY = result.NAGENCY,
            DLEDGERDAT = result.DLEDGERDAT,
            DSTATDATE = result.DSTATDATE,
            SPAY_FORM = result.SPAY_FORM,
            NCOVBAS = result.NCOVBAS,
            NCOVADD = result.NCOVADD,
            NTAX = result.NTAX,
            NREC_DESC = result.NREC_DESC,
            NBORDERUSED = result.NBORDERUSED,
            NBORDEREAUX_USERCOD = result.NBORDEREAUX_USERCOD,
            NCASHNUM = result.NCASHNUM,
            SCLIENTSPONSOR = result.SCLIENTSPONSOR,
            SCLIENT_ASEG = result.SCLIENT_ASEG,
            NPREMIUME_MO = result.NPREMIUME_MO,
            NPREMIUMA_MO = result.NPREMIUMA_MO,
            NTAXAMOUNT_MO = result.NTAXAMOUNT_MO,
            NPREMIUM_MO = result.NPREMIUM_MO,
            NPREMIUME = result.NPREMIUME,
            NPREMIUMA = result.NPREMIUMA,
            NTAXAMOUNT = result.NTAXAMOUNT,
            NPREMIUM = result.NPREMIUM,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NTYPE_TRAN = result.NTYPE_TRAN,
            DSTATDATE_NEW = result.DSTATDATE_NEW,
            DSTATDATE_OLD = result.DSTATDATE_OLD,
            NBILLNUM = result.NBILLNUM,
            NUSER_OLD = result.NUSER_OLD,
            NUSER = result.NUSER,
        };
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_COLLECTION/Edit.cshtml", updateDto);
    }

    // POST: BOOK_COLLECTION/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateBOOK_COLLECTIONDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateTABLE24DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5556DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        return View("~/Views/Insudb/BOOK_COLLECTION/Edit.cshtml", updateDto);
    }

    // GET: BOOK_COLLECTION/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/BOOK_COLLECTION/Delete.cshtml", result);
    }

    // POST: BOOK_COLLECTION/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
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

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE_TRAN"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

}
