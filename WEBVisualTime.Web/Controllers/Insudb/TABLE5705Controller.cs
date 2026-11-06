using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5705;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5705Controller : CatalogController<TABLE5705Dto, CreateTABLE5705Dto, UpdateTABLE5705Dto, int>
{
    public TABLE5705Controller(ITABLE5705Service service)
        : base(service, "TABLE5705", "NSYSTEM", new[] { "NSYSTEM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
