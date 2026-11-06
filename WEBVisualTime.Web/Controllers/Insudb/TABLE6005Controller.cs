using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6005Controller : CatalogController<TABLE6005Dto, CreateTABLE6005Dto, UpdateTABLE6005Dto, int>
{
    public TABLE6005Controller(ITABLE6005Service service)
        : base(service, "TABLE6005", "NOWNERSHIP", new[] { "NOWNERSHIP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
