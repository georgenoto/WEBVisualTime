using WEBVisualTime.Servicios.Insudb.DTOs.TABLE195;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE195Controller : CatalogController<TABLE195Dto, CreateTABLE195Dto, UpdateTABLE195Dto, long>
{
    public TABLE195Controller(ITABLE195Service service)
        : base(service, "TABLE195", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
