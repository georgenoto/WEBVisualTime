using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE95Controller : CatalogController<TABLE95Dto, CreateTABLE95Dto, UpdateTABLE95Dto, int>
{
    public TABLE95Controller(ITABLE95Service service)
        : base(service, "TABLE95", "NNULLCODE", new[] { "NNULLCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
