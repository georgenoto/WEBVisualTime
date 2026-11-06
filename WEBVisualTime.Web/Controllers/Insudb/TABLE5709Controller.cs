using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5709;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5709Controller : CatalogController<TABLE5709Dto, CreateTABLE5709Dto, UpdateTABLE5709Dto, long>
{
    public TABLE5709Controller(ITABLE5709Service service)
        : base(service, "TABLE5709", "NTYPE", new[] { "NTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
