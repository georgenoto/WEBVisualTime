using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5902;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5902Controller : CatalogController<TABLE5902Dto, CreateTABLE5902Dto, UpdateTABLE5902Dto, int>
{
    public TABLE5902Controller(ITABLE5902Service service)
        : base(service, "TABLE5902", "NTYPE_MAIL", new[] { "NTYPE_MAIL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
