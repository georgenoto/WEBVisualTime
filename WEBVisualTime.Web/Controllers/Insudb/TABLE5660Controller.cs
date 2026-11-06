using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5660;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5660Controller : CatalogController<TABLE5660Dto, CreateTABLE5660Dto, UpdateTABLE5660Dto, int>
{
    public TABLE5660Controller(ITABLE5660Service service)
        : base(service, "TABLE5660", "NTYPE_CALC", new[] { "NTYPE_CALC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
