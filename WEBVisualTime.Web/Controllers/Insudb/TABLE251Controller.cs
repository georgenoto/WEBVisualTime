using WEBVisualTime.Servicios.Insudb.DTOs.TABLE251;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE251Controller : CatalogController<TABLE251Dto, CreateTABLE251Dto, UpdateTABLE251Dto, long>
{
    public TABLE251Controller(ITABLE251Service service)
        : base(service, "TABLE251", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
