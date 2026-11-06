using WEBVisualTime.Servicios.Insudb.DTOs.TABLE253;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE253Controller : CatalogController<TABLE253Dto, CreateTABLE253Dto, UpdateTABLE253Dto, int>
{
    public TABLE253Controller(ITABLE253Service service)
        : base(service, "TABLE253", "NSTAT_DRAFT", new[] { "NSTAT_DRAFT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
