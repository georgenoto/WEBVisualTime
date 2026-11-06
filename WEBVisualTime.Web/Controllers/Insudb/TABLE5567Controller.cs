using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5567;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5567Controller : CatalogController<TABLE5567Dto, CreateTABLE5567Dto, UpdateTABLE5567Dto, int>
{
    public TABLE5567Controller(ITABLE5567Service service)
        : base(service, "TABLE5567", "NTYPMOV_COMM", new[] { "NTYPMOV_COMM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
