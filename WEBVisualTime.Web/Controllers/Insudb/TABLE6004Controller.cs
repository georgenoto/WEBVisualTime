using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6004Controller : CatalogController<TABLE6004Dto, CreateTABLE6004Dto, UpdateTABLE6004Dto, int>
{
    public TABLE6004Controller(ITABLE6004Service service)
        : base(service, "TABLE6004", "NSWIMPOOL", new[] { "NSWIMPOOL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
