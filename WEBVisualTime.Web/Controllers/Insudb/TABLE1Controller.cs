using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1Controller : CatalogController<TABLE1Dto, CreateTABLE1Dto, UpdateTABLE1Dto, long>
{
    public TABLE1Controller(ITABLE1Service service)
        : base(service, "TABLE1", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
