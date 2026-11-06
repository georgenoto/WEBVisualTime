using WEBVisualTime.Servicios.Insudb.DTOs.TABLE311;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE311Controller : CatalogController<TABLE311Dto, CreateTABLE311Dto, UpdateTABLE311Dto, int>
{
    public TABLE311Controller(ITABLE311Service service)
        : base(service, "TABLE311", "NARITOPER", new[] { "NARITOPER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
