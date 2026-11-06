using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7014Controller : CatalogController<TABLE7014Dto, CreateTABLE7014Dto, UpdateTABLE7014Dto, long>
{
    public TABLE7014Controller(ITABLE7014Service service)
        : base(service, "TABLE7014", "NTYPE_INF", new[] { "NTYPE_INF", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
