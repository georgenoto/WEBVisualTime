using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8204Controller : CatalogController<TABLE8204Dto, CreateTABLE8204Dto, UpdateTABLE8204Dto, string>
{
    public TABLE8204Controller(ITABLE8204Service service)
        : base(service, "TABLE8204", "STYP_CONDI", new[] { "STYP_CONDI", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
