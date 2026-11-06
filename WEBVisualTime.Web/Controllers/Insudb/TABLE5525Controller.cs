using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5525;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5525Controller : CatalogController<TABLE5525Dto, CreateTABLE5525Dto, UpdateTABLE5525Dto, int>
{
    public TABLE5525Controller(ITABLE5525Service service)
        : base(service, "TABLE5525", "NTYPEMOVE", new[] { "NTYPEMOVE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
