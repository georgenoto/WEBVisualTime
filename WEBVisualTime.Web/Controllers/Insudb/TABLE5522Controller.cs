using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5522;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5522Controller : CatalogController<TABLE5522Dto, CreateTABLE5522Dto, UpdateTABLE5522Dto, int>
{
    public TABLE5522Controller(ITABLE5522Service service)
        : base(service, "TABLE5522", "NINVOICING", new[] { "NINVOICING", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
