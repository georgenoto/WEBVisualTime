using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.PREMIUM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Insudb.DTOs.CLIENT;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE19;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.DTOs.INTERMEDIA;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.DTOs.COMPANY;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5600;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.DTOs.COLLECTOR;
using WEBVisualTime.Servicios.Insudb.DTOs.AGREEMENT;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PREMIUMController : Controller
{
    private readonly IPREMIUMService _service;
    private readonly ICERTIFICATService _CERTIFICATService;
    private readonly ICLIENTService _CLIENTService;
    private readonly ITABLE19Service _TABLE19Service;
    private readonly ITABLE181Service _TABLE181Service;
    private readonly IINTERMEDIAService _INTERMEDIAService;
    private readonly ITABLE95Service _TABLE95Service;
    private readonly ITABLE9Service _TABLE9Service;
    private readonly ITABLE24Service _TABLE24Service;
    private readonly ICOMPANYService _COMPANYService;
    private readonly ITABLE5002Service _TABLE5002Service;
    private readonly ITABLE5001Service _TABLE5001Service;
    private readonly ITABLE5600Service _TABLE5600Service;
    private readonly ITABLE5566Service _TABLE5566Service;
    private readonly ICOLLECTORService _COLLECTORService;
    private readonly IAGREEMENTService _AGREEMENTService;

    public PREMIUMController(IPREMIUMService service
        , ICERTIFICATService CERTIFICATService
        , ICLIENTService CLIENTService
        , ITABLE19Service TABLE19Service
        , ITABLE181Service TABLE181Service
        , IINTERMEDIAService INTERMEDIAService
        , ITABLE95Service TABLE95Service
        , ITABLE9Service TABLE9Service
        , ITABLE24Service TABLE24Service
        , ICOMPANYService COMPANYService
        , ITABLE5002Service TABLE5002Service
        , ITABLE5001Service TABLE5001Service
        , ITABLE5600Service TABLE5600Service
        , ITABLE5566Service TABLE5566Service
        , ICOLLECTORService COLLECTORService
        , IAGREEMENTService AGREEMENTService
    )
    {
        _service = service;
        _CERTIFICATService = CERTIFICATService;
        _CLIENTService = CLIENTService;
        _TABLE19Service = TABLE19Service;
        _TABLE181Service = TABLE181Service;
        _INTERMEDIAService = INTERMEDIAService;
        _TABLE95Service = TABLE95Service;
        _TABLE9Service = TABLE9Service;
        _TABLE24Service = TABLE24Service;
        _COMPANYService = COMPANYService;
        _TABLE5002Service = TABLE5002Service;
        _TABLE5001Service = TABLE5001Service;
        _TABLE5600Service = TABLE5600Service;
        _TABLE5566Service = TABLE5566Service;
        _COLLECTORService = COLLECTORService;
        _AGREEMENTService = AGREEMENTService;
    }

    // GET: PREMIUM
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/PREMIUM/Index.cshtml", result);
    }

    // GET: PREMIUM/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM/Details.cshtml", result);
    }

    // GET: PREMIUM/Create
    public async Task<IActionResult> Create()
    {
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE19DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5600DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/PREMIUM/Create.cshtml", new CreatePREMIUMDto());
    }

    // POST: PREMIUM/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreatePREMIUMDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE19DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5600DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/PREMIUM/Create.cshtml", createDto);
    }

    // GET: PREMIUM/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdatePREMIUMDto
        {
            SCERTYPE = result.SCERTYPE,
            NRECEIPT = result.NRECEIPT,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NDIGIT = result.NDIGIT,
            NPAYNUMBE = result.NPAYNUMBE,
            SCLIENT = result.SCLIENT,
            NPOLICY = result.NPOLICY,
            SCESSIONS = result.SCESSIONS,
            NCERTIF = result.NCERTIF,
            SDIRDEBIT = result.SDIRDEBIT,
            SLEADINVO = result.SLEADINVO,
            SMANAUTI = result.SMANAUTI,
            SRENEWAL = result.SRENEWAL,
            SSUBSTITI = result.SSUBSTITI,
            NSTATUS_PRE = result.NSTATUS_PRE,
            SCONCOLL = result.SCONCOLL,
            SSTATUSVA = result.SSTATUSVA,
            DCOMPDATE = result.DCOMPDATE,
            DEFFECDATE = result.DEFFECDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            DISSUEDAT = result.DISSUEDAT,
            DNULLDATE = result.DNULLDATE,
            DPAYDATE = result.DPAYDATE,
            DSTATDATE = result.DSTATDATE,
            NBALANCE = result.NBALANCE,
            NCOMAMOU = result.NCOMAMOU,
            NEXCHANGE = result.NEXCHANGE,
            NINTAMMOU = result.NINTAMMOU,
            NPARTICIP = result.NPARTICIP,
            NPREMIUM = result.NPREMIUM,
            NPREMIUML = result.NPREMIUML,
            NPREMIUMN = result.NPREMIUMN,
            NPREMIUMS = result.NPREMIUMS,
            NRATE = result.NRATE,
            NTAXAMOU = result.NTAXAMOU,
            NCOLLECTO = result.NCOLLECTO,
            NCONTRAT = result.NCONTRAT,
            NINSPECTO = result.NINSPECTO,
            NINTERMED = result.NINTERMED,
            NSUSTIT = result.NSUSTIT,
            NTRANSACTIO = result.NTRANSACTIO,
            NNULLCODE = result.NNULLCODE,
            NCURRENCY = result.NCURRENCY,
            NNOTENUM = result.NNOTENUM,
            NOFFICE = result.NOFFICE,
            NTYPE = result.NTYPE,
            NTRATYPEI = result.NTRATYPEI,
            NUSERCODE = result.NUSERCODE,
            NPERIOD = result.NPERIOD,
            NCOMPANY = result.NCOMPANY,
            SORIGRECEIPT = result.SORIGRECEIPT,
            NWAY_PAY = result.NWAY_PAY,
            DLIMITDATE = result.DLIMITDATE,
            NINSUR_AREA = result.NINSUR_AREA,
            NINDRECDEP = result.NINDRECDEP,
            DCOLLSUS_INI = result.DCOLLSUS_INI,
            DCOLLSUS_END = result.DCOLLSUS_END,
            NSUS_REASON = result.NSUS_REASON,
            SSUS_ORIGI = result.SSUS_ORIGI,
            SREJECT = result.SREJECT,
            NCOLLECTOR = result.NCOLLECTOR,
            NIDLOANS = result.NIDLOANS,
            NCOD_AGREE = result.NCOD_AGREE,
            SBILLTYPE = result.SBILLTYPE,
            NBILLNUM = result.NBILLNUM,
            SINDCHEQUE = result.SINDCHEQUE,
            SIND_CAP = result.SIND_CAP,
            NBULLETINS = result.NBULLETINS,
            SINDMARGIN = result.SINDMARGIN,
            SIND_RESERV = result.SIND_RESERV,
            NYEARMONTHDESC = result.NYEARMONTHDESC,
            NBILL_DAY = result.NBILL_DAY,
            NPAYFREQ = result.NPAYFREQ,
            SDOCUMENT = result.SDOCUMENT,
            NBANK_CODE = result.NBANK_CODE,
            NSITUATION = result.NSITUATION,
            NSTIPEND_AMOUNT = result.NSTIPEND_AMOUNT,
            NCOLLECTOR_ASSIG = result.NCOLLECTOR_ASSIG,
            NPREMIUMTEC = result.NPREMIUMTEC,
            SCLINUMDOCU = result.SCLINUMDOCU,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            NCLASSTYPDOC = result.NCLASSTYPDOC,
            NMOVEMENT = result.NMOVEMENT,
            NMOVEMENT_NULL = result.NMOVEMENT_NULL,
        };
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE19DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5600DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/PREMIUM/Edit.cshtml", updateDto);
    }

    // POST: PREMIUM/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdatePREMIUMDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SCERTYPE, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        await PopulateCERTIFICATDropdownAsync();
        await PopulateCLIENTDropdownAsync();
        await PopulateTABLE19DropdownAsync();
        await PopulateTABLE181DropdownAsync();
        await PopulateINTERMEDIADropdownAsync();
        await PopulateTABLE95DropdownAsync();
        await PopulateTABLE9DropdownAsync();
        await PopulateTABLE24DropdownAsync();
        await PopulateCOMPANYDropdownAsync();
        await PopulateTABLE5002DropdownAsync();
        await PopulateTABLE5001DropdownAsync();
        await PopulateTABLE5600DropdownAsync();
        await PopulateTABLE5566DropdownAsync();
        await PopulateCOLLECTORDropdownAsync();
        await PopulateAGREEMENTDropdownAsync();
        return View("~/Views/Insudb/PREMIUM/Edit.cshtml", updateDto);
    }

    // GET: PREMIUM/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/PREMIUM/Delete.cshtml", result);
    }

    // POST: PREMIUM/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    // GET: PREMIUM/GetBySCERTYPE?SCERTYPE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetBySCERTYPE(string SCERTYPE)
    {
        var items = await _service.FindAsync(p => p.SCERTYPE == SCERTYPE);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCESSIONS }));
    }

    // GET: PREMIUM/GetByNINTERMED?NINTERMED=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNINTERMED(long NINTERMED)
    {
        var items = await _service.FindAsync(p => p.NINTERMED == NINTERMED);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCESSIONS }));
    }

    // GET: PREMIUM/GetByNNULLCODE?NNULLCODE=value (cascade)
    [HttpGet]
    public async Task<JsonResult> GetByNNULLCODE(int NNULLCODE)
    {
        var items = await _service.FindAsync(p => p.NNULLCODE == NNULLCODE);
        return Json(items.Select(i => new { value = i.SCERTYPE, text = i.SCESSIONS }));
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

    private async Task PopulateCLIENTDropdownAsync()
    {
        var items = await _CLIENTService.GetAllAsync();
        ViewData["SCLIENT"] = new SelectList(items, nameof(CLIENTDto.SCLIENT), "SACCOUNT_IN");
    }

    private async Task PopulateTABLE19DropdownAsync()
    {
        var items = await _TABLE19Service.GetAllAsync();
        ViewData["NSTATUS_PRE"] = new SelectList(items, nameof(TABLE19Dto.NSTATUS_PRE), "SDESCRIPT");
    }

    private async Task PopulateTABLE181DropdownAsync()
    {
        var items = await _TABLE181Service.GetAllAsync();
        ViewData["SSTATUSVA"] = new SelectList(items, nameof(TABLE181Dto.SSTATUSVA), "SDESCRIPT");
    }

    private async Task PopulateINTERMEDIADropdownAsync()
    {
        var items = await _INTERMEDIAService.GetAllAsync();
        ViewData["NINTERMED"] = new SelectList(items, nameof(INTERMEDIADto.NINTERMED), "SCOL_AGREE");
    }

    private async Task PopulateTABLE95DropdownAsync()
    {
        var items = await _TABLE95Service.GetAllAsync();
        ViewData["NNULLCODE"] = new SelectList(items, nameof(TABLE95Dto.NNULLCODE), "SDESCRIPT");
    }

    private async Task PopulateTABLE9DropdownAsync()
    {
        var items = await _TABLE9Service.GetAllAsync();
        ViewData["NOFFICE"] = new SelectList(items, nameof(TABLE9Dto.NOFFICE), "SDESCRIPT");
    }

    private async Task PopulateTABLE24DropdownAsync()
    {
        var items = await _TABLE24Service.GetAllAsync();
        ViewData["NTRATYPEI"] = new SelectList(items, nameof(TABLE24Dto.NTRATYPEI), "SDESCRIPT");
    }

    private async Task PopulateCOMPANYDropdownAsync()
    {
        var items = await _COMPANYService.GetAllAsync();
        ViewData["NCOMPANY"] = new SelectList(items, nameof(COMPANYDto.NCOMPANY), "SACCOUNT");
    }

    private async Task PopulateTABLE5002DropdownAsync()
    {
        var items = await _TABLE5002Service.GetAllAsync();
        ViewData["NWAY_PAY"] = new SelectList(items, nameof(TABLE5002Dto.NWAY_PAY), "SDESCRIPT");
    }

    private async Task PopulateTABLE5001DropdownAsync()
    {
        var items = await _TABLE5001Service.GetAllAsync();
        ViewData["NINSUR_AREA"] = new SelectList(items, nameof(TABLE5001Dto.NINSUR_AREA), "SDESCRIPT");
    }

    private async Task PopulateTABLE5600DropdownAsync()
    {
        var items = await _TABLE5600Service.GetAllAsync();
        ViewData["NINDRECDEP"] = new SelectList(items, nameof(TABLE5600Dto.NINDRECDEP), "SDESCRIPT");
    }

    private async Task PopulateTABLE5566DropdownAsync()
    {
        var items = await _TABLE5566Service.GetAllAsync();
        ViewData["NSUS_REASON"] = new SelectList(items, nameof(TABLE5566Dto.NSUS_REASON), "SDESCRIPT");
    }

    private async Task PopulateCOLLECTORDropdownAsync()
    {
        var items = await _COLLECTORService.GetAllAsync();
        ViewData["NCOLLECTOR"] = new SelectList(items, nameof(COLLECTORDto.NCOLLECTOR), "NCOLLECTOR");
    }

    private async Task PopulateAGREEMENTDropdownAsync()
    {
        var items = await _AGREEMENTService.GetAllAsync();
        ViewData["NCOD_AGREE"] = new SelectList(items, nameof(AGREEMENTDto.NCOD_AGREE), "SSTATREGT");
    }

}
