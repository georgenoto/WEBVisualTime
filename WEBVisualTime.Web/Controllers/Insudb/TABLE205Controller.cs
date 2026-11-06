using WEBVisualTime.Servicios.Insudb.DTOs.TABLE205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE205Controller : CatalogController<TABLE205Dto, CreateTABLE205Dto, UpdateTABLE205Dto, int>
{
    public TABLE205Controller(ITABLE205Service service)
        : base(service, "TABLE205", "NINFRACTION", new[] { "NINFRACTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
