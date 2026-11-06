using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9205Controller : CatalogController<TABLE9205Dto, CreateTABLE9205Dto, UpdateTABLE9205Dto, int>
{
    public TABLE9205Controller(ITABLE9205Service service)
        : base(service, "TABLE9205", "NCITY_AXE", new[] { "NCITY_AXE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
