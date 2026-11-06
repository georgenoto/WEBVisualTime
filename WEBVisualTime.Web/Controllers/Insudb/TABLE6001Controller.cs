using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6001Controller : CatalogController<TABLE6001Dto, CreateTABLE6001Dto, UpdateTABLE6001Dto, int>
{
    public TABLE6001Controller(ITABLE6001Service service)
        : base(service, "TABLE6001", "NAIRTYPE", new[] { "NAIRTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
