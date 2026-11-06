using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8002Controller : CatalogController<TABLE8002Dto, CreateTABLE8002Dto, UpdateTABLE8002Dto, int>
{
    public TABLE8002Controller(ITABLE8002Service service)
        : base(service, "TABLE8002", "NVALDATE_ISSUE", new[] { "NVALDATE_ISSUE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
