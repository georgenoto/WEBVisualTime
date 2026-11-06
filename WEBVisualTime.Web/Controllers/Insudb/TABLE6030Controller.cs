using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6030Controller : CatalogController<TABLE6030Dto, CreateTABLE6030Dto, UpdateTABLE6030Dto, int>
{
    public TABLE6030Controller(ITABLE6030Service service)
        : base(service, "TABLE6030", "NTYPECALCULATE", new[] { "NTYPECALCULATE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
