using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9105;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9105Controller : CatalogController<TABLE9105Dto, CreateTABLE9105Dto, UpdateTABLE9105Dto, int>
{
    public TABLE9105Controller(ITABLE9105Service service)
        : base(service, "TABLE9105", "NROUTINETYPE", new[] { "NROUTINETYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
