using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9040;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9040Controller : CatalogController<TABLE9040Dto, CreateTABLE9040Dto, UpdateTABLE9040Dto, int>
{
    public TABLE9040Controller(ITABLE9040Service service)
        : base(service, "TABLE9040", "NTYPE_SETTLE", new[] { "NTYPE_SETTLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
