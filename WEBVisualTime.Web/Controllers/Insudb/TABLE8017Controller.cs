using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8017;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8017Controller : CatalogController<TABLE8017Dto, CreateTABLE8017Dto, UpdateTABLE8017Dto, int>
{
    public TABLE8017Controller(ITABLE8017Service service)
        : base(service, "TABLE8017", "NFIELD", new[] { "NFIELD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
