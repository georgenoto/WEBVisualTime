using WEBVisualTime.Servicios.Insudb.DTOs.PROVISION_TYPE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PROVISION_TYPEController : CatalogController<PROVISION_TYPEDto, CreatePROVISION_TYPEDto, UpdatePROVISION_TYPEDto, int>
{
    public PROVISION_TYPEController(IPROVISION_TYPEService service)
        : base(service, "PROVISION_TYPE", "NIDPROVISIONTYPE", new[] { "NIDPROVISIONTYPE", "SNAME", "SENABLE", "SMANEJAUF" }) { }
}
