using WEBVisualTime.Servicios.Insudb.DTOs.TABLE37;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE37Controller : CatalogController<TABLE37Dto, CreateTABLE37Dto, UpdateTABLE37Dto, string>
{
    public TABLE37Controller(ITABLE37Service service)
        : base(service, "TABLE37", "SBRANCHT", new[] { "SBRANCHT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
