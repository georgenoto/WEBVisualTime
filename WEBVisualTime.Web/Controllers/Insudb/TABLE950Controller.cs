using WEBVisualTime.Servicios.Insudb.DTOs.TABLE950;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE950Controller : CatalogController<TABLE950Dto, CreateTABLE950Dto, UpdateTABLE950Dto, long>
{
    public TABLE950Controller(ITABLE950Service service)
        : base(service, "TABLE950", "NTYP_PROFITWORKER", new[] { "NTYP_PROFITWORKER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
