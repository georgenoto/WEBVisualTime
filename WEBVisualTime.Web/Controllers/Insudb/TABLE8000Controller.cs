using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8000Controller : CatalogController<TABLE8000Dto, CreateTABLE8000Dto, UpdateTABLE8000Dto, int>
{
    public TABLE8000Controller(ITABLE8000Service service)
        : base(service, "TABLE8000", "NTYPEDOC", new[] { "NTYPEDOC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
