using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6014Controller : CatalogController<TABLE6014Dto, CreateTABLE6014Dto, UpdateTABLE6014Dto, int>
{
    public TABLE6014Controller(ITABLE6014Service service)
        : base(service, "TABLE6014", "NSEVERITY", new[] { "NSEVERITY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
