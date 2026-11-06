using WEBVisualTime.Servicios.Insudb.DTOs.TABLE283;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE283Controller : CatalogController<TABLE283Dto, CreateTABLE283Dto, UpdateTABLE283Dto, int>
{
    public TABLE283Controller(ITABLE283Service service)
        : base(service, "TABLE283", "NPOSITION", new[] { "NPOSITION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
