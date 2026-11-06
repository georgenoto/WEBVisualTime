using WEBVisualTime.Servicios.Insudb.DTOs.TABLE80;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE80Controller : CatalogController<TABLE80Dto, CreateTABLE80Dto, UpdateTABLE80Dto, string>
{
    public TABLE80Controller(ITABLE80Service service)
        : base(service, "TABLE80", "SLICENSE_TY", new[] { "SLICENSE_TY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
