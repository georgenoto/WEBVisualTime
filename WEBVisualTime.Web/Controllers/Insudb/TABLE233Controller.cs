using WEBVisualTime.Servicios.Insudb.DTOs.TABLE233;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE233Controller : CatalogController<TABLE233Dto, CreateTABLE233Dto, UpdateTABLE233Dto, int>
{
    public TABLE233Controller(ITABLE233Service service)
        : base(service, "TABLE233", "NCONSTCAT", new[] { "NCONSTCAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
