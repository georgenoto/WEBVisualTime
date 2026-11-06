using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8215Controller : CatalogController<TABLE8215Dto, CreateTABLE8215Dto, UpdateTABLE8215Dto, int>
{
    public TABLE8215Controller(ITABLE8215Service service)
        : base(service, "TABLE8215", "NTYPE_VALUECOLLECT", new[] { "NTYPE_VALUECOLLECT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
