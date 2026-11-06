using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE173Controller : CatalogController<TABLE173Dto, CreateTABLE173Dto, UpdateTABLE173Dto, int>
{
    public TABLE173Controller(ITABLE173Service service)
        : base(service, "TABLE173", "NTYPE_REIN", new[] { "NTYPE_REIN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
