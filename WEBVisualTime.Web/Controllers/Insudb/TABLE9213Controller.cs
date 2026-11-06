using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9213;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9213Controller : CatalogController<TABLE9213Dto, CreateTABLE9213Dto, UpdateTABLE9213Dto, int>
{
    public TABLE9213Controller(ITABLE9213Service service)
        : base(service, "TABLE9213", "NPOSITION_CLI", new[] { "NPOSITION_CLI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
