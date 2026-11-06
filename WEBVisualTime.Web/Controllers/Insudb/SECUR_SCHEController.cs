using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class SECUR_SCHEController : CatalogController<SECUR_SCHEDto, CreateSECUR_SCHEDto, UpdateSECUR_SCHEDto, string>
{
    public SECUR_SCHEController(ISECUR_SCHEService service)
        : base(service, "SECUR_SCHE", "SSCHE_CODE", new[] { "SSCHE_CODE", "NACCESOF", "DCOMPDATE", "DDATE_FROM", "DDATE_TO", "NIND_CURREN", "NIND_LIMITS", "SLONGDESC", "NSECURLEV", "SSHORTDES", "SSTATREGT", "STIME1_FROM", "STIME1_TO", "STIME2_FROM", "STIME2_TO", "STIMEQ1_FRO", "STIMEQ1_TO", "STIMEQ2_FRO", "STIMEQ2_TO", "SUSEQUERY", "NIND_CONCE", "NUSERCODE", "NDURATION", "NDAYSADV", "SENCRYPTED" }) { }
}
