using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7000Controller : CatalogController<TABLE7000Dto, CreateTABLE7000Dto, UpdateTABLE7000Dto, int>
{
    public TABLE7000Controller(ITABLE7000Service service)
        : base(service, "TABLE7000", "NTABLE", new[] { "NTABLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
