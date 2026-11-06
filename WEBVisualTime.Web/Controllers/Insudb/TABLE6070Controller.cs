using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6070;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6070Controller : CatalogController<TABLE6070Dto, CreateTABLE6070Dto, UpdateTABLE6070Dto, string>
{
    public TABLE6070Controller(ITABLE6070Service service)
        : base(service, "TABLE6070", "STRATYPEI", new[] { "STRATYPEI", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
