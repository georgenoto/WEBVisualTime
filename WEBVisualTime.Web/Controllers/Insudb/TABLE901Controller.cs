using WEBVisualTime.Servicios.Insudb.DTOs.TABLE901;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE901Controller : CatalogController<TABLE901Dto, CreateTABLE901Dto, UpdateTABLE901Dto, long>
{
    public TABLE901Controller(ITABLE901Service service)
        : base(service, "TABLE901", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
