using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6071;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6071Controller : CatalogController<TABLE6071Dto, CreateTABLE6071Dto, UpdateTABLE6071Dto, int>
{
    public TABLE6071Controller(ITABLE6071Service service)
        : base(service, "TABLE6071", "NTYPE_ACC", new[] { "NTYPE_ACC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
