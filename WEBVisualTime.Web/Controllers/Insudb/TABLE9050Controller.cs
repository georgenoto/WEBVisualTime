using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9050;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9050Controller : CatalogController<TABLE9050Dto, CreateTABLE9050Dto, UpdateTABLE9050Dto, int>
{
    public TABLE9050Controller(ITABLE9050Service service)
        : base(service, "TABLE9050", "NFORMPAY", new[] { "NFORMPAY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
