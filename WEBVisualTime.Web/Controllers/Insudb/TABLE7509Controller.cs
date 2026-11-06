using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7509;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7509Controller : CatalogController<TABLE7509Dto, CreateTABLE7509Dto, UpdateTABLE7509Dto, int>
{
    public TABLE7509Controller(ITABLE7509Service service)
        : base(service, "TABLE7509", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
