using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5571;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5571Controller : CatalogController<TABLE5571Dto, CreateTABLE5571Dto, UpdateTABLE5571Dto, int>
{
    public TABLE5571Controller(ITABLE5571Service service)
        : base(service, "TABLE5571", "NSEARCH", new[] { "NSEARCH", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
