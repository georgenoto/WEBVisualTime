using WEBVisualTime.Servicios.Insudb.DTOs.TABLE32;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE32Controller : CatalogController<TABLE32Dto, CreateTABLE32Dto, UpdateTABLE32Dto, int>
{
    public TABLE32Controller(ITABLE32Service service)
        : base(service, "TABLE32", "NCRTHECNI", new[] { "NCRTHECNI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NTABLE8000" }) { }
}
