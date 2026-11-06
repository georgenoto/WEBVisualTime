using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5560;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5560Controller : CatalogController<TABLE5560Dto, CreateTABLE5560Dto, UpdateTABLE5560Dto, int>
{
    public TABLE5560Controller(ITABLE5560Service service)
        : base(service, "TABLE5560", "NCALCAPITAL", new[] { "NCALCAPITAL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
