using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5527;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5527Controller : CatalogController<TABLE5527Dto, CreateTABLE5527Dto, UpdateTABLE5527Dto, int>
{
    public TABLE5527Controller(ITABLE5527Service service)
        : base(service, "TABLE5527", "NTYPEPAY", new[] { "NTYPEPAY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
