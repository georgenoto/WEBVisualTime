using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5610;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5610Controller : CatalogController<TABLE5610Dto, CreateTABLE5610Dto, UpdateTABLE5610Dto, int>
{
    public TABLE5610Controller(ITABLE5610Service service)
        : base(service, "TABLE5610", "NTYPEREC", new[] { "NTYPEREC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
