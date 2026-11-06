using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE46Controller : CatalogController<TABLE46Dto, CreateTABLE46Dto, UpdateTABLE46Dto, string>
{
    public TABLE46Controller(ITABLE46Service service)
        : base(service, "TABLE46", "SREVALTYP", new[] { "SREVALTYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
