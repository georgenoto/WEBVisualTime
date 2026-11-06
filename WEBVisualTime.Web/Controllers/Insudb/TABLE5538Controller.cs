using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5538;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5538Controller : CatalogController<TABLE5538Dto, CreateTABLE5538Dto, UpdateTABLE5538Dto, int>
{
    public TABLE5538Controller(ITABLE5538Service service)
        : base(service, "TABLE5538", "NSTRUCTURE_TYPE", new[] { "NSTRUCTURE_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
