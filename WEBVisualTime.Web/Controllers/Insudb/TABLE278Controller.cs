using WEBVisualTime.Servicios.Insudb.DTOs.TABLE278;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE278Controller : CatalogController<TABLE278Dto, CreateTABLE278Dto, UpdateTABLE278Dto, int>
{
    public TABLE278Controller(ITABLE278Service service)
        : base(service, "TABLE278", "NSTAT_CONTR", new[] { "NSTAT_CONTR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
