using WEBVisualTime.Servicios.Insudb.DTOs.TABLE181;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE181Controller : CatalogController<TABLE181Dto, CreateTABLE181Dto, UpdateTABLE181Dto, string>
{
    public TABLE181Controller(ITABLE181Service service)
        : base(service, "TABLE181", "SSTATUSVA", new[] { "SSTATUSVA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
