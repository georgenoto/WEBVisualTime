using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5625;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5625Controller : CatalogController<TABLE5625Dto, CreateTABLE5625Dto, UpdateTABLE5625Dto, int>
{
    public TABLE5625Controller(ITABLE5625Service service)
        : base(service, "TABLE5625", "NTYPE", new[] { "NTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
