using WEBVisualTime.Servicios.Insudb.DTOs.TABLE527;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE527Controller : CatalogController<TABLE527Dto, CreateTABLE527Dto, UpdateTABLE527Dto, int>
{
    public TABLE527Controller(ITABLE527Service service)
        : base(service, "TABLE527", "NSINIES_TYPE", new[] { "NSINIES_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
