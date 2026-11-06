using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6900;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6900Controller : CatalogController<TABLE6900Dto, CreateTABLE6900Dto, UpdateTABLE6900Dto, int>
{
    public TABLE6900Controller(ITABLE6900Service service)
        : base(service, "TABLE6900", "NINSMODALITY", new[] { "NINSMODALITY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
