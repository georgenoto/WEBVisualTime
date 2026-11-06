using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6028Controller : CatalogController<TABLE6028Dto, CreateTABLE6028Dto, UpdateTABLE6028Dto, int>
{
    public TABLE6028Controller(ITABLE6028Service service)
        : base(service, "TABLE6028", "NGROUPVEH", new[] { "NGROUPVEH", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
