using WEBVisualTime.Servicios.Insudb.DTOs.TABLE999;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE999Controller : CatalogController<TABLE999Dto, CreateTABLE999Dto, UpdateTABLE999Dto, string>
{
    public TABLE999Controller(ITABLE999Service service)
        : base(service, "TABLE999", "SSTAT_ERROR", new[] { "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "SSTAT_ERROR" }) { }
}
