using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5749;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5749Controller : CatalogController<TABLE5749Dto, CreateTABLE5749Dto, UpdateTABLE5749Dto, int>
{
    public TABLE5749Controller(ITABLE5749Service service)
        : base(service, "TABLE5749", "NTYPEVAL", new[] { "NTYPEVAL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
