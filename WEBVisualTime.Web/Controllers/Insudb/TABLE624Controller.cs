using WEBVisualTime.Servicios.Insudb.DTOs.TABLE624;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE624Controller : CatalogController<TABLE624Dto, CreateTABLE624Dto, UpdateTABLE624Dto, int>
{
    public TABLE624Controller(ITABLE624Service service)
        : base(service, "TABLE624", "NSTATLETTER", new[] { "NSTATLETTER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
