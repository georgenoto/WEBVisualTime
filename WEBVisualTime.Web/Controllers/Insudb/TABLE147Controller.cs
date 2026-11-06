using WEBVisualTime.Servicios.Insudb.DTOs.TABLE147;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE147Controller : CatalogController<TABLE147Dto, CreateTABLE147Dto, UpdateTABLE147Dto, int>
{
    public TABLE147Controller(ITABLE147Service service)
        : base(service, "TABLE147", "NECONOMIC_L", new[] { "NECONOMIC_L", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
