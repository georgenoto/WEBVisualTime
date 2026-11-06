using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9300Controller : CatalogController<TABLE9300Dto, CreateTABLE9300Dto, UpdateTABLE9300Dto, int>
{
    public TABLE9300Controller(ITABLE9300Service service)
        : base(service, "TABLE9300", "NPROMISSORYNOTE", new[] { "NPROMISSORYNOTE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
