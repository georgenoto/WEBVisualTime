using WEBVisualTime.Servicios.Insudb.DTOs.TABLE174;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE174Controller : CatalogController<TABLE174Dto, CreateTABLE174Dto, UpdateTABLE174Dto, int>
{
    public TABLE174Controller(ITABLE174Service service)
        : base(service, "TABLE174", "NCLASS_AP", new[] { "NCLASS_AP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
