using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9253;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9253Controller : CatalogController<TABLE9253Dto, CreateTABLE9253Dto, UpdateTABLE9253Dto, int>
{
    public TABLE9253Controller(ITABLE9253Service service)
        : base(service, "TABLE9253", "NCLASS_PROV", new[] { "NCLASS_PROV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
