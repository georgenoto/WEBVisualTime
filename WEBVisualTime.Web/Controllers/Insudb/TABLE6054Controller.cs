using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6054;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6054Controller : CatalogController<TABLE6054Dto, CreateTABLE6054Dto, UpdateTABLE6054Dto, int>
{
    public TABLE6054Controller(ITABLE6054Service service)
        : base(service, "TABLE6054", "NSECTION", new[] { "NSECTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
