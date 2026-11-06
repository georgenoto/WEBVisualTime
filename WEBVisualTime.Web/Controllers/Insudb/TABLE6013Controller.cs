using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6013Controller : CatalogController<TABLE6013Dto, CreateTABLE6013Dto, UpdateTABLE6013Dto, int>
{
    public TABLE6013Controller(ITABLE6013Service service)
        : base(service, "TABLE6013", "NUNIT", new[] { "NUNIT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
