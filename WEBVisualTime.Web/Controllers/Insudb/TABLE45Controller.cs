using WEBVisualTime.Servicios.Insudb.DTOs.TABLE45;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE45Controller : CatalogController<TABLE45Dto, CreateTABLE45Dto, UpdateTABLE45Dto, string>
{
    public TABLE45Controller(ITABLE45Service service)
        : base(service, "TABLE45", "SHOLDER", new[] { "SHOLDER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
