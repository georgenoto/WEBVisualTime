using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6031Controller : CatalogController<TABLE6031Dto, CreateTABLE6031Dto, UpdateTABLE6031Dto, int>
{
    public TABLE6031Controller(ITABLE6031Service service)
        : base(service, "TABLE6031", "NTRANSPTYPE", new[] { "NTRANSPTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
