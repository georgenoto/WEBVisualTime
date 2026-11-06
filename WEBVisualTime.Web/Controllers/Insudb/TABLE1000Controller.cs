using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1000Controller : CatalogController<TABLE1000Dto, CreateTABLE1000Dto, UpdateTABLE1000Dto, int>
{
    public TABLE1000Controller(ITABLE1000Service service)
        : base(service, "TABLE1000", "NCODTOLER", new[] { "NCODTOLER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
