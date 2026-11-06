using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6002Controller : CatalogController<TABLE6002Dto, CreateTABLE6002Dto, UpdateTABLE6002Dto, int>
{
    public TABLE6002Controller(ITABLE6002Service service)
        : base(service, "TABLE6002", "NALT_HEATING", new[] { "NALT_HEATING", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
