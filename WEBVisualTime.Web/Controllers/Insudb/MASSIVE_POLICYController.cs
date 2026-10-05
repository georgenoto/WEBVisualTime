using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_POLICY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Servicios.Insudb.Mappings;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MASSIVE_POLICYController : Controller
{
    private readonly IMASSIVE_POLICYService _service;

    public MASSIVE_POLICYController(IMASSIVE_POLICYService service
    )
    {
        _service = service;
    }

    // GET: MASSIVE_POLICY
    public async Task<IActionResult> Index()
    {
        var result = await _service.GetAllAsync();
        return View("~/Views/Insudb/MASSIVE_POLICY/Index.cshtml", result);
    }

    // GET: MASSIVE_POLICY/Details/{id}
    public async Task<IActionResult> Details(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_POLICY/Details.cshtml", result);
    }

    // GET: MASSIVE_POLICY/Create
    public async Task<IActionResult> Create()
    {
        return View("~/Views/Insudb/MASSIVE_POLICY/Create.cshtml", new CreateMASSIVE_POLICYDto());
    }

    // POST: MASSIVE_POLICY/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateMASSIVE_POLICYDto createDto)
    {
        if (ModelState.IsValid)
        {
            await _service.CreateAsync(createDto);
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_POLICY/Create.cshtml", createDto);
    }

    // GET: MASSIVE_POLICY/Edit/{id}
    public async Task<IActionResult> Edit(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();

        var updateDto = new UpdateMASSIVE_POLICYDto
        {
            SKEY = result.SKEY,
            NROW = result.NROW,
            NSEQ = result.NSEQ,
            SERROR = result.SERROR,
            NACTION = result.NACTION,
            NGROUP = result.NGROUP,
            SCLIENT_S = result.SCLIENT_S,
            SCERTYPE = result.SCERTYPE,
            NBRANCH = result.NBRANCH,
            NPRODUCT = result.NPRODUCT,
            NPOLICY = result.NPOLICY,
            NCERTIF = result.NCERTIF,
            SCLIENT = result.SCLIENT,
            NROLE = result.NROLE,
            NPARTICIP = result.NPARTICIP,
            DBIRTHDATE = result.DBIRTHDATE,
            SSEXCLIEN = result.SSEXCLIEN,
            SSMOKING = result.SSMOKING,
            NTYPERISK = result.NTYPERISK,
            SFIRSTNAME = result.SFIRSTNAME,
            SLASTNAME = result.SLASTNAME,
            SLASTNAME2 = result.SLASTNAME2,
            SCLIENAME = result.SCLIENAME,
            NCIVILSTA = result.NCIVILSTA,
            SRECTYPE = result.SRECTYPE,
            SSTREET = result.SSTREET,
            SE_MAIL = result.SE_MAIL,
            NPROVINCE = result.NPROVINCE,
            NLOCAL = result.NLOCAL,
            NMUNICIPALITY1 = result.NMUNICIPALITY1,
            NFLOOR = result.NFLOOR,
            NPHONE_TYPE = result.NPHONE_TYPE,
            SPHONE = result.SPHONE,
            NINTERMED = result.NINTERMED,
            NGROUP_INSU = result.NGROUP_INSU,
            NMODULEC = result.NMODULEC,
            SITEM = result.SITEM,
            DSTARTDATE = result.DSTARTDATE,
            DEXPIRDAT = result.DEXPIRDAT,
            DNULLDATE = result.DNULLDATE,
            NNULLCODE = result.NNULLCODE,
            NPAYFREQ = result.NPAYFREQ,
            NCAPITAL = result.NCAPITAL,
            NPREMIUM = result.NPREMIUM,
            NSITUATION = result.NSITUATION,
            NWAY_PAY = result.NWAY_PAY,
            NSELLCHANNEL = result.NSELLCHANNEL,
            NDAY_PAY = result.NDAY_PAY,
            NCOD_AGREE = result.NCOD_AGREE,
            NRENTAMOUNT = result.NRENTAMOUNT,
            NCURRRENT = result.NCURRRENT,
            SCREDITNUM = result.SCREDITNUM,
            DINIT_CRE = result.DINIT_CRE,
            NAMOUNT_ACT = result.NAMOUNT_ACT,
            NRATEDESG = result.NRATEDESG,
            NTAXREGIME = result.NTAXREGIME,
            NQ_QUOT = result.NQ_QUOT,
            NPREMDEAL = result.NPREMDEAL,
            NOPTION = result.NOPTION,
            SACCOUNT = result.SACCOUNT,
            NBANKEXT = result.NBANKEXT,
            SCREDI_CARD = result.SCREDI_CARD,
            NTYP_CRECARD = result.NTYP_CRECARD,
            STYP_DIRDEB = result.STYP_DIRDEB,
            DCARDEXPIR = result.DCARDEXPIR,
            NTYP_ACC = result.NTYP_ACC,
            NAGENCY = result.NAGENCY,
            SCHASSIS = result.SCHASSIS,
            NVEHTYPE = result.NVEHTYPE,
            SMOTOR = result.SMOTOR,
            SREGIST = result.SREGIST,
            NAMOUNT_CRE = result.NAMOUNT_CRE,
            NPREMIUM_CA = result.NPREMIUM_CA,
            NCAPITAL_CA = result.NCAPITAL_CA,
            SBUILD = result.SBUILD,
            SDEPARTMENT = result.SDEPARTMENT,
            NZIP_CODE = result.NZIP_CODE,
            SVEHCODE = result.SVEHCODE,
            NRELATION = result.NRELATION,
            DCOMPDATE = result.DCOMPDATE,
            NUSERCODE = result.NUSERCODE,
            SCLIENTSPONSOR = result.SCLIENTSPONSOR,
            SCOMERPRODUCT = result.SCOMERPRODUCT,
            NCOMBPOLICY = result.NCOMBPOLICY,
            SSTATUSVA = result.SSTATUSVA,
            SCLINUMDOCU = result.SCLINUMDOCU,
            NCAMPAIGN = result.NCAMPAIGN,
            NCAMP_RELEASE = result.NCAMP_RELEASE,
            NCOMMERNUM = result.NCOMMERNUM,
            DISSUEDAT = result.DISSUEDAT,
            NTYPCLIENTDOC = result.NTYPCLIENTDOC,
            SDESCADD = result.SDESCADD,
            SDESCADD1 = result.SDESCADD1,
            NZIP_CODE1 = result.NZIP_CODE1,
            NLOCAL1 = result.NLOCAL1,
            NPROVINCE1 = result.NPROVINCE1,
            SCELULAR = result.SCELULAR,
            NCURRENCY = result.NCURRENCY,
            SCBU = result.SCBU,
            NEXPCYCLE = result.NEXPCYCLE,
            NEXPIRRULE = result.NEXPIRRULE,
            NRECEIPT = result.NRECEIPT,
            NNATIONALITY = result.NNATIONALITY,
            NPROFIT_SITUATION = result.NPROFIT_SITUATION,
            NVAT_SITUATION = result.NVAT_SITUATION,
            NBILL_DAY = result.NBILL_DAY,
            NMUNICIPALITY = result.NMUNICIPALITY,
            SDIGIT = result.SDIGIT,
            SINDBILLER = result.SINDBILLER,
            SIDCOMPL = result.SIDCOMPL,
            SIDCERTIF = result.SIDCERTIF,
            SDESCGROUP = result.SDESCGROUP,
            SDESCMODUL = result.SDESCMODUL,
            SINDMATERNITY = result.SINDMATERNITY,
            NCITY_RESIDENCE = result.NCITY_RESIDENCE,
            NCOUNTRY = result.NCOUNTRY,
            NAREA_CODCELU = result.NAREA_CODCELU,
            NAREA_CODPHONE = result.NAREA_CODPHONE,
            SMARRIEDSURNAME = result.SMARRIEDSURNAME,
            SSPOUSENAME = result.SSPOUSENAME,
            NTITLE = result.NTITLE,
            NSPECIALITY = result.NSPECIALITY,
            SSTREET1 = result.SSTREET1,
            SBUILD1 = result.SBUILD1,
            NFLOOR1 = result.NFLOOR1,
            SDEPARTMENT1 = result.SDEPARTMENT1,
            NCOUNTRY1 = result.NCOUNTRY1,
            SE_MAIL1 = result.SE_MAIL1,
            NAREA_CODCELU1 = result.NAREA_CODCELU1,
            SCELULAR1 = result.SCELULAR1,
            NAREA_CODPHONE1 = result.NAREA_CODPHONE1,
            SPHONE1 = result.SPHONE1,
            SSENDADDRESS = result.SSENDADDRESS,
            SCERTADDRESS = result.SCERTADDRESS,
            NWEIGHT = result.NWEIGHT,
            NHEIGHT = result.NHEIGHT,
            SINDANTI = result.SINDANTI,
            DANTIDATE = result.DANTIDATE,
            NANTI_AMOUNT = result.NANTI_AMOUNT,
            SFPHYSICAL_CREDEN = result.SFPHYSICAL_CREDEN,
            SDPSDELIVERED = result.SDPSDELIVERED,
            SIDDELIVERED = result.SIDDELIVERED,
            DLIMIT_DATEDOC = result.DLIMIT_DATEDOC,
            NGROUP_INSUDEST = result.NGROUP_INSUDEST,
            SDESCGROUP_DEST = result.SDESCGROUP_DEST,
            NMODULEC_DEST = result.NMODULEC_DEST,
            SDESCMODUL_DEST = result.SDESCMODUL_DEST,
            SPREVNUMPOL = result.SPREVNUMPOL,
            DDATEORIGINCERT = result.DDATEORIGINCERT,
            SCLINUMDOCU_BILL = result.SCLINUMDOCU_BILL,
            NTYPCLIENTDOC_BILL = result.NTYPCLIENTDOC_BILL,
        };
        return View("~/Views/Insudb/MASSIVE_POLICY/Edit.cshtml", updateDto);
    }

    // POST: MASSIVE_POLICY/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateMASSIVE_POLICYDto updateDto)
    {
        if (ModelState.IsValid)
        {
            var success = await _service.UpdateAsync(updateDto.SKEY, updateDto);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        return View("~/Views/Insudb/MASSIVE_POLICY/Edit.cshtml", updateDto);
    }

    // GET: MASSIVE_POLICY/Delete/{id}
    public async Task<IActionResult> Delete(string id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null) return NotFound();
        return View("~/Views/Insudb/MASSIVE_POLICY/Delete.cshtml", result);
    }

    // POST: MASSIVE_POLICY/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    {
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

}
