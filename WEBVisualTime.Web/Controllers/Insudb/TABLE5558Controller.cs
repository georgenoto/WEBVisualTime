using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5558;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5558Controller : CatalogController<TABLE5558Dto, CreateTABLE5558Dto, UpdateTABLE5558Dto, int>
{
    public TABLE5558Controller(ITABLE5558Service service)
        : base(service, "TABLE5558", "NTYPEREC", new[] { "NTYPEREC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
