using WEBVisualTime.Servicios.Insudb.DTOs.TABLE93;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE93Controller : CatalogController<TABLE93Dto, CreateTABLE93Dto, UpdateTABLE93Dto, int>
{
    public TABLE93Controller(ITABLE93Service service)
        : base(service, "TABLE93", "NTIME_UNIT", new[] { "NTIME_UNIT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
