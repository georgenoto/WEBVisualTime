using WEBVisualTime.Servicios.Insudb.DTOs.ACTIONS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ACTIONSController : CatalogController<ACTIONSDto, CreateACTIONSDto, UpdateACTIONSDto, int>
{
    public ACTIONSController(IACTIONSService service)
        : base(service, "ACTIONS", "NACTION", new[] { "NACTION", "SCONTROLKEY", "SDESCRIPT", "SHEL_ACTIO", "SSHORT_ACTI", "SSTATREGT", "STYPE_ACTIO", "DCOMPDATE", "NUSERCODE", "SPATHIMAGE" }) { }
}
