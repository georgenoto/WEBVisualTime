using WEBVisualTime.Servicios.Insudb.DTOs.TABLE59;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE59Controller : CatalogController<TABLE59Dto, CreateTABLE59Dto, UpdateTABLE59Dto, int>
{
    public TABLE59Controller(ITABLE59Service service)
        : base(service, "TABLE59", "NTYPE_PARAMETER", new[] { "NTYPE_PARAMETER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
