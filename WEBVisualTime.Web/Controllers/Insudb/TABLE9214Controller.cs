using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9214;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9214Controller : CatalogController<TABLE9214Dto, CreateTABLE9214Dto, UpdateTABLE9214Dto, int>
{
    public TABLE9214Controller(ITABLE9214Service service)
        : base(service, "TABLE9214", "NGEOGRAPHAREA", new[] { "NGEOGRAPHAREA", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
