using WEBVisualTime.Servicios.Insudb.DTOs.TABLE290;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE290Controller : CatalogController<TABLE290Dto, CreateTABLE290Dto, UpdateTABLE290Dto, long>
{
    public TABLE290Controller(ITABLE290Service service)
        : base(service, "TABLE290", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
