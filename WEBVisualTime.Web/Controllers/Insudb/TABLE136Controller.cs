using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE136Controller : CatalogController<TABLE136Dto, CreateTABLE136Dto, UpdateTABLE136Dto, int>
{
    public TABLE136Controller(ITABLE136Service service)
        : base(service, "TABLE136", "NNULLCODE", new[] { "NNULLCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
