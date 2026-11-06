using WEBVisualTime.Servicios.Insudb.DTOs.TABLE333;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE333Controller : CatalogController<TABLE333Dto, CreateTABLE333Dto, UpdateTABLE333Dto, int>
{
    public TABLE333Controller(ITABLE333Service service)
        : base(service, "TABLE333", "NTYPE_MOVE", new[] { "NTYPE_MOVE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
