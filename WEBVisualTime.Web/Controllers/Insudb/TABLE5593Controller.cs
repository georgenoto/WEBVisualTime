using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5593;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5593Controller : CatalogController<TABLE5593Dto, CreateTABLE5593Dto, UpdateTABLE5593Dto, int>
{
    public TABLE5593Controller(ITABLE5593Service service)
        : base(service, "TABLE5593", "NMEASUNIT", new[] { "NMEASUNIT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
