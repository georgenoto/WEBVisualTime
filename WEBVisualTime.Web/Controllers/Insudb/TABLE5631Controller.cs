using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5631;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5631Controller : CatalogController<TABLE5631Dto, CreateTABLE5631Dto, UpdateTABLE5631Dto, int>
{
    public TABLE5631Controller(ITABLE5631Service service)
        : base(service, "TABLE5631", "NCAUSE", new[] { "NCAUSE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
