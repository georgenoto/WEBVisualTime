using WEBVisualTime.Servicios.Insudb.DTOs.TABLE994;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE994Controller : CatalogController<TABLE994Dto, CreateTABLE994Dto, UpdateTABLE994Dto, int>
{
    public TABLE994Controller(ITABLE994Service service)
        : base(service, "TABLE994", "NACTION", new[] { "NACTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
