using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6Controller : CatalogController<TABLE6Dto, CreateTABLE6Dto, UpdateTABLE6Dto, int>
{
    public TABLE6Controller(ITABLE6Service service)
        : base(service, "TABLE6", "NTYPE_TRAN", new[] { "NTYPE_TRAN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
