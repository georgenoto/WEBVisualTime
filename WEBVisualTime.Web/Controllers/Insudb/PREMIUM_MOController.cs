using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM_MO;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.DTOs.COLFORMREF;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE77;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PREMIUM_MOController : Controller
{
    private readonly IPREMIUM_MOService _service;
    private readonly IPREMIUMService _PREMIUMService;
    private readonly ITABLE183Service _TABLE183Service;
    private readonly ITABLE7Service _TABLE7Service;
    private readonly ICOLFORMREFService _COLFORMREFService;
    private readonly ITABLE77Service _TABLE77Service;
    private readonly ITABLE95Service _TABLE95Service;
    private readonly ITABLE182Service _TABLE182Service;
    private readonly ITABLE6Service _TABLE6Service;
    private readonly ICOLLECTORService _COLLECTORService;

    public PREMIUM_MOController(IPREMIUM_MOService service
        , IPREMIUMService PREMIUMService
        , ITABLE183Service TABLE183Service
        , ITABLE7Service TABLE7Service
        , ICOLFORMREFService COLFORMREFService
        , ITABLE77Service TABLE77Service
        , ITABLE95Service TABLE95Service
        , ITABLE182Service TABLE182Service
        , ITABLE6Service TABLE6Service
        , ICOLLECTORService COLLECTORService
    )
    {
        _service = service;
        _PREMIUMService = PREMIUMService;
        _TABLE183Service = TABLE183Service;
        _TABLE7Service = TABLE7Service;
        _COLFORMREFService = COLFORMREFService;
        _TABLE77Service = TABLE77Service;
        _TABLE95Service = TABLE95Service;
        _TABLE182Service = TABLE182Service;
        _TABLE6Service = TABLE6Service;
        _COLLECTORService = COLLECTORService;
    }

    // GET: PREMIUM_MO
    public Task<IActionResult> Index(int page = 1, string? q = null)
        => WEBVisualTime.Web.Controllers.Common.ListPageLoader.LoadAsync(
            this, _service, page, q, "~/Views/Insudb/PREMIUM_MO/Index.cshtml");

    // GET: PREMIUM_MO/Details/{id}
    public async Task<IActionResult> Details(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_MO/Details.cshtml", result);
    }

    // GET: PREMIUM_MO/Create
    public async Task<IActionResult> Create()
    {
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE77DropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/PREMIUM_MO/Create.cshtml", new CreatePREMIUM_MODto());
    }

    // POST: PREMIUM_MO/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePREMIUM_MODto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE77DropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/PREMIUM_MO/Create.cshtml", createDto);
    }

    // GET: PREMIUM_MO/Edit/{id}
    public async Task<IActionResult> Edit(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePREMIUM_MODto
        {
            NRECEIPT = result.NRECEIPT,
            NPRODUCT = result.NPRODUCT,
            NBRANCH = result.NBRANCH,
            SCERTYPE = result.SCERTYPE,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            NTRANSAC = result.NTRANSAC,
            NAMOUNT = result.NAMOUNT,
            NCARD_TYPE = result.NCARD_TYPE,
            SAUX_ACCOUN = result.SAUX_ACCOUN,
            NBALANCE = result.NBALANCE,
            NBANK_CODE = result.NBANK_CODE,
            NBORDEREAUX = result.NBORDEREAUX,
            DCAR_DATEXP = result.DCAR_DATEXP,
            SCARD_NUM = result.SCARD_NUM,
            NCASH_MOV = result.NCASH_MOV,
            NCAUSE_AMEN = result.NCAUSE_AMEN,
            SCESSICOI = result.SCESSICOI,
            SCHANG_ACC = result.SCHANG_ACC,
            DCOMPDATE = result.DCOMPDATE,
            NCURRENCY = result.NCURRENCY,
            SDOCNUMBE = result.SDOCNUMBE,
            SIND_REVER = result.SIND_REVER,
            NINT_MORA = result.NINT_MORA,
            SINTERMEI = result.SINTERMEI,
            NNULLCODE = result.NNULLCODE,
            SPAY_FORM = result.SPAY_FORM,
            DPOSTED = result.DPOSTED,
            NPREMIUM = result.NPREMIUM,
            NRECEIPT_FA = result.NRECEIPT_FA,
            DSTATDATE = result.DSTATDATE,
            SSTATISI = result.SSTATISI,
            NUSERCODE = result.NUSERCODE,
            DLEDGERDAT = result.DLEDGERDAT,
            NTYPE = result.NTYPE,
            NEXCHANGE = result.NEXCHANGE,
            SINDASSOCPRO = result.SINDASSOCPRO,
            NPAYSOONDISC = result.NPAYSOONDISC,
            SIND_ASIS = result.SIND_ASIS,
            SIND_COMI = result.SIND_COMI,
            NBULLETINS = result.NBULLETINS,
            NCASHNUM = result.NCASHNUM,
            NPAYREJECT = result.NPAYREJECT,
            NCOLLECTOR = result.NCOLLECTOR,
            NBILLNUM = result.NBILLNUM,
            SBILLTYPE = result.SBILLTYPE,
            SIND_SOAP = result.SIND_SOAP,
            SINDCHEQUE = result.SINDCHEQUE,
            NID = result.NID,
            NRELRECEIPT = result.NRELRECEIPT,
            SPROCESS_IND = result.SPROCESS_IND,
            SSTIPENDS = result.SSTIPENDS,
            NPAY_SOURCE = result.NPAY_SOURCE,
            STYPREVERSE = result.STYPREVERSE,
            NAMOUNT_LOC = result.NAMOUNT_LOC,
            NCOD_AGREE = result.NCOD_AGREE,
            NCONTRAT = result.NCONTRAT,
            DCTB_DATE = result.DCTB_DATE,
            SPOSTEDSEQUENCE = result.SPOSTEDSEQUENCE,
            NCOLLECTOR_ASSIG = result.NCOLLECTOR_ASSIG,
            NBORDEREAUX_ADV = result.NBORDEREAUX_ADV,
            NBILLNUM_OLD = result.NBILLNUM_OLD,
        };
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE77DropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/PREMIUM_MO/Edit.cshtml", updateDto);
    }

    // POST: PREMIUM_MO/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePREMIUM_MODto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.NRECEIPT, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulatePREMIUMDropdownAsync();
        await PopulateTABLE183DropdownAsync();
        await PopulateTABLE7DropdownAsync();
        await PopulateCOLFORMREFDropdownAsync();
        await PopulateTABLE77DropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE182DropdownAsync();
        await PopulateTABLE6DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        return View("~/Views/Insudb/PREMIUM_MO/Edit.cshtml", updateDto);
    }

    // GET: PREMIUM_MO/Delete/{id}
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM_MO/Delete.cshtml", result);
    }

    // POST: PREMIUM_MO/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    private async Task PopulatePREMIUMDropdownAsync()
    {
        var items = await _PREMIUMService.GetAllAsync();
        ViewData["NRECEIPT"] = new SelectList(items, nameof(PREMIUMDto.NRECEIPT), "SCESSIONS");
        ViewData["NPRODUCT"] = new SelectList(items, nameof(PREMIUMDto.NPRODUCT), "SCESSIONS");
        ViewData["NBRANCH"] = new SelectList(items, nameof(PREMIUMDto.NBRANCH), "SCESSIONS");
        ViewData["SCERTYPE"] = new SelectList(items, nameof(PREMIUMDto.SCERTYPE), "SCESSIONS");
        ViewData["NDIGIT"] = new SelectList(items, nameof(PREMIUMDto.NDIGIT), "SCESSIONS");
        ViewData["NPAYNUMBE"] = new SelectList(items, nameof(PREMIUMDto.NPAYNUMBE), "SCESSIONS");
    }

    private async Task PopulateTABLE183DropdownAsync()
    {
        var items = await _TABLE183Service.GetAllAsync();
        ViewData["NCARD_TYPE"] = new SelectList(items, nameof(TABLE183Dto.NCARD_TYPE), "SDESCRIPT");
    }

    private async Task PopulateTABLE7DropdownAsync()
    {
        var items = await _TABLE7Service.GetAllAsync();
        ViewData["NBANK_CODE"] = new SelectList(items, nameof(TABLE7Dto.NBANK_CODE), "SDESCRIPT");
    }

    private async Task PopulateCOLFORMREFDropdownAsync()
    {
        var items = await _COLFORMREFService.GetAllAsync();
        ViewData["NBORDEREAUX"] = new SelectList(items, nameof(COLFORMREFDto.NBORDEREAUX), "STYPE");
    }

    private async Task PopulateTABLE77DropdownAsync()
    {
        var items = await _TABLE77Service.GetAllAsync();
        ViewData["NCAUSE_AMEN"] = new SelectList(items, nameof(TABLE77Dto.NCAUSE_AMEN), "SDESCRIPT");
    }

    private async Task PopulateTABLE95DropdownAsync()
    {
        var items = await _TABLE95Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE95Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE182DropdownAsync()
    {
        var items = await _TABLE182Service.GetAllAsync();
        ViewData["SPAY_FORM"] = new SelectList(items, nameof(TABLE182Dto.SPAY_FORM), "SDESCRIPT");
    }

    private async Task PopulateTABLE6DropdownAsync()
    {
        var items = await _TABLE6Service.GetAllAsync();
        ViewData["NTYPE"] = new SelectList(items, nameof(TABLE6Dto.NTYPE_TRAN), "SDESCRIPT");
    }

    private async Task PopulateCOLLECTORDropdownAsync()
    {
        var items = await _COLLECTORService.GetAllAsync();
        ViewData["NCOLLECTOR"] = new SelectList(items, nameof(COLLECTORDto.NCOLLECTOR), "NCOLLECTOR");
    }

}
