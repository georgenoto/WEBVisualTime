using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.REQ_ENDOR;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class REQ_ENDORController : Controller
{
    private readonly IREQ_ENDORService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ITABLE6059Service _TABLE6059Service;
    private readonly IUSERSService _USERSService;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE5555Service _TABLE5555Service;

    public REQ_ENDORController(IREQ_ENDORService service
        , ICERTIFICATService CERTIFICATService
        , ITABLE6059Service TABLE6059Service
        , IUSERSService USERSService
        , ITABLE9Service TABLE9Service
        , ITABLE5555Service TABLE5555Service
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _TABLE6059Service = TABLE6059Service;
        _USERSService = USERSService;
        _TABLE9Service = TABLE9Service;
        _TABLE5555Service = TABLE5555Service;
    }

    // GET: REQ_ENDOR
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/REQ_ENDOR/Index.cshtml", result);
    }

    // GET: REQ_ENDOR/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REQ_ENDOR/Details.cshtml", result);
    }

    // GET: REQ_ENDOR/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/REQ_ENDOR/Create.cshtml", new CreateREQ_ENDORDto());
    }

    // POST: REQ_ENDOR/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateREQ_ENDORDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/REQ_ENDOR/Create.cshtml", createDto);
    }

    // GET: REQ_ENDOR/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateREQ_ENDORDto
        {
            NREQENDOR = result.NREQENDOR,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            DREQSTARTENDOR = result.DREQSTARTENDOR,
            NTYPEENDOR = result.NTYPEENDOR,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            NUNDERWRITINGCASEID = result.NUNDERWRITINGCASEID,
            NINTERMED = result.NINTERMED,
            NOFFICE = result.NOFFICE,
            NAGENCY = result.NAGENCY,
            SCERTYPEENDOR = result.SCERTYPEENDOR,
            NPOLICYENDOR = result.NPOLICYENDOR,
            SOBS = result.SOBS,
            SREASON_REJECT = result.SREASON_REJECT,
            NUSERCODE_REJECT = result.NUSERCODE_REJECT,
            DREJECT = result.DREJECT,
            NID_SECUENCIA = result.NID_SECUENCIA,
            NUSERCODE_REQ = result.NUSERCODE_REQ,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/REQ_ENDOR/Edit.cshtml", updateDto);
    }

    // POST: REQ_ENDOR/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateREQ_ENDORDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NREQENDOR, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateTABLE6059DropdownAsync();
        await PopulateUSERSDropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE5555DropdownAsync();
        return View("~/Views/Insudb/REQ_ENDOR/Edit.cshtml", updateDto);
    }

    // GET: REQ_ENDOR/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/REQ_ENDOR/Delete.cshtml", result);
    }

    // POST: REQ_ENDOR/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulateCERTIFICATDropdownAsync()
    {
        var items = await _CERTIFICATService.GetAllAsync();
        ViewData["SCERTYPE"] = new SelectList(items, nameof(CERTIFICATDto.SCERTYPE), "SCUMUL_CODE");
        ViewData["NBRANCH"] = new SelectList(items, nameof(CERTIFICATDto.NBRANCH), "SCUMUL_CODE");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(CERTIFICATDto.NPRODUCT), "SCUMUL_CODE");
        ViewData["NPOLICY"] = new SelectList(items, nameof(CERTIFICATDto.NPOLICY), "SCUMUL_CODE");
        ViewData["NCERTIF"] = new SelectList(items, nameof(CERTIFICATDto.NCERTIF), "SCUMUL_CODE");
    }

    private async Task PopulateTABLE6059DropdownAsync()
    {
        var items = await _TABLE6059Service.GetAllAsync();
        ViewData["NTYPEENDOR"] = new SelectList(items, nameof(TABLE6059Dto.NTYPE_AMEND), "SDESCRIPT");
    }

    private async Task PopulateUSERSDropdownAsync()
    {
        var items = await _USERSService.GetAllAsync();
        ViewData["NUSERCODE"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSERCODE_REJECT"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
        ViewData["NUSERCODE_REQ"] = new SelectList(items, nameof(USERSDto.NUSERCODE), "SACCESSWO");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE5555DropdownAsync()
    {
        var items = await _TABLE5555Service.GetAllAsync();
        ViewData["NAGENCY"] = new SelectList(items, nameof(TABLE5555Dto.NAGENCY), "SDESCRIPT");
    }

}
