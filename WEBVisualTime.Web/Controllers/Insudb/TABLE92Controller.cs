using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE92Controller : CatalogController<TABLE92Dto, CreateTABLE92Dto, UpdateTABLE92Dto, string>
{
    public TABLE92Controller(ITABLE92Service service)
        : base(service, "TABLE92", "STYP_VAR", new[] { "STYP_VAR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
