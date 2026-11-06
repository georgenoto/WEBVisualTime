using WEBVisualTime.Servicios.Insudb.DTOs.TABLE88;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE88Controller : CatalogController<TABLE88Dto, CreateTABLE88Dto, UpdateTABLE88Dto, int>
{
    public TABLE88Controller(ITABLE88Service service)
        : base(service, "TABLE88", "NWINDOWTY", new[] { "NWINDOWTY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
