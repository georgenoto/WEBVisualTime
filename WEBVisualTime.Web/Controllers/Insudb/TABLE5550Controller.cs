using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5550;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5550Controller : CatalogController<TABLE5550Dto, CreateTABLE5550Dto, UpdateTABLE5550Dto, int>
{
    public TABLE5550Controller(ITABLE5550Service service)
        : base(service, "TABLE5550", "NINCAP_COD", new[] { "NINCAP_COD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
