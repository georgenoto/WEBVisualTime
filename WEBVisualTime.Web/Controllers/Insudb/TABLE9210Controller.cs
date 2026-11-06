using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9210Controller : CatalogController<TABLE9210Dto, CreateTABLE9210Dto, UpdateTABLE9210Dto, int>
{
    public TABLE9210Controller(ITABLE9210Service service)
        : base(service, "TABLE9210", "NTEMPASSI", new[] { "NTEMPASSI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
