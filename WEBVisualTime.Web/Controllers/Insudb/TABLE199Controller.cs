using WEBVisualTime.Servicios.Insudb.DTOs.TABLE199;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE199Controller : CatalogController<TABLE199Dto, CreateTABLE199Dto, UpdateTABLE199Dto, int>
{
    public TABLE199Controller(ITABLE199Service service)
        : base(service, "TABLE199", "NPAY_TYPE", new[] { "NPAY_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
