using WEBVisualTime.Servicios.Insudb.DTOs.TABLE252;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE252Controller : CatalogController<TABLE252Dto, CreateTABLE252Dto, UpdateTABLE252Dto, long>
{
    public TABLE252Controller(ITABLE252Service service)
        : base(service, "TABLE252", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
