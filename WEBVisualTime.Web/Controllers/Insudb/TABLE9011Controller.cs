using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9011;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9011Controller : CatalogController<TABLE9011Dto, CreateTABLE9011Dto, UpdateTABLE9011Dto, int>
{
    public TABLE9011Controller(ITABLE9011Service service)
        : base(service, "TABLE9011", "NCNTRYRISK", new[] { "NCNTRYRISK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
