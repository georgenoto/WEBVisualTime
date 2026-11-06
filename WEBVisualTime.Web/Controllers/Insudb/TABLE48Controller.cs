using WEBVisualTime.Servicios.Insudb.DTOs.TABLE48;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE48Controller : CatalogController<TABLE48Dto, CreateTABLE48Dto, UpdateTABLE48Dto, int>
{
    public TABLE48Controller(ITABLE48Service service)
        : base(service, "TABLE48", "NTYPE_RESERVE", new[] { "NTYPE_RESERVE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
