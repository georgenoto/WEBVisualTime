using WEBVisualTime.Servicios.Insudb.DTOs.TABLE902;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE902Controller : CatalogController<TABLE902Dto, CreateTABLE902Dto, UpdateTABLE902Dto, long>
{
    public TABLE902Controller(ITABLE902Service service)
        : base(service, "TABLE902", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
