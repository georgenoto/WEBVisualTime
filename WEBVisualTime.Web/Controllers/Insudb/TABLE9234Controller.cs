using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9234;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9234Controller : CatalogController<TABLE9234Dto, CreateTABLE9234Dto, UpdateTABLE9234Dto, int>
{
    public TABLE9234Controller(ITABLE9234Service service)
        : base(service, "TABLE9234", "NTYP_SECTION", new[] { "NTYP_SECTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
