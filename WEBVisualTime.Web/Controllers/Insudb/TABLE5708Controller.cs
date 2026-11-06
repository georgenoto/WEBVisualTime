using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5708Controller : CatalogController<TABLE5708Dto, CreateTABLE5708Dto, UpdateTABLE5708Dto, long>
{
    public TABLE5708Controller(ITABLE5708Service service)
        : base(service, "TABLE5708", "NTYPE_MOVE", new[] { "NTYPE_MOVE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NTYPE", "SPB_BMG", "NLOAD_TYPE" }) { }
}
