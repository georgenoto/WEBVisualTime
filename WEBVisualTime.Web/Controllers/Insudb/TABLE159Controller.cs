using WEBVisualTime.Servicios.Insudb.DTOs.TABLE159;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE159Controller : CatalogController<TABLE159Dto, CreateTABLE159Dto, UpdateTABLE159Dto, int>
{
    public TABLE159Controller(ITABLE159Service service)
        : base(service, "TABLE159", "NGROUP_PRES", new[] { "NGROUP_PRES", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
