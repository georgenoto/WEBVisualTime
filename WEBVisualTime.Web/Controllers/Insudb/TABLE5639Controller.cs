using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5639;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5639Controller : CatalogController<TABLE5639Dto, CreateTABLE5639Dto, UpdateTABLE5639Dto, int>
{
    public TABLE5639Controller(ITABLE5639Service service)
        : base(service, "TABLE5639", "NTYPERISK", new[] { "NTYPERISK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
