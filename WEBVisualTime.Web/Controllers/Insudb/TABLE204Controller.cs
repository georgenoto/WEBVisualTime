using WEBVisualTime.Servicios.Insudb.DTOs.TABLE204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE204Controller : CatalogController<TABLE204Dto, CreateTABLE204Dto, UpdateTABLE204Dto, int>
{
    public TABLE204Controller(ITABLE204Service service)
        : base(service, "TABLE204", "NBLAME", new[] { "NBLAME", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
