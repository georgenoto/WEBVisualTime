using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1008Controller : CatalogController<TABLE1008Dto, CreateTABLE1008Dto, UpdateTABLE1008Dto, int>
{
    public TABLE1008Controller(ITABLE1008Service service)
        : base(service, "TABLE1008", "NVAL_ASSO", new[] { "NVAL_ASSO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
