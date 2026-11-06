using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class GROUPPARAMSController : CatalogController<GROUPPARAMSDto, CreateGROUPPARAMSDto, UpdateGROUPPARAMSDto, int>
{
    public GROUPPARAMSController(IGROUPPARAMSService service)
        : base(service, "GROUPPARAMS", "NLETT_GROUP", new[] { "NLETT_GROUP", "DCOMPDATE", "SDESCRIPT", "NUSERCODE", "SPARAMETERS" }) { }
}
