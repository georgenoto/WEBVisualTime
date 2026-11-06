using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5584;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5584Controller : CatalogController<TABLE5584Dto, CreateTABLE5584Dto, UpdateTABLE5584Dto, int>
{
    public TABLE5584Controller(ITABLE5584Service service)
        : base(service, "TABLE5584", "NTYPE_TAR", new[] { "NTYPE_TAR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
