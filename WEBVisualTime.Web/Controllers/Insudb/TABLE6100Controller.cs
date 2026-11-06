using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6100Controller : CatalogController<TABLE6100Dto, CreateTABLE6100Dto, UpdateTABLE6100Dto, int>
{
    public TABLE6100Controller(ITABLE6100Service service)
        : base(service, "TABLE6100", "NCLASEMPRESALEGAL", new[] { "NCLASEMPRESALEGAL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
