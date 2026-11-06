using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5546;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5546Controller : CatalogController<TABLE5546Dto, CreateTABLE5546Dto, UpdateTABLE5546Dto, int>
{
    public TABLE5546Controller(ITABLE5546Service service)
        : base(service, "TABLE5546", "NLEVEL", new[] { "NLEVEL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
