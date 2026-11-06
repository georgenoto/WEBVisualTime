using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5009;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5009Controller : CatalogController<TABLE5009Dto, CreateTABLE5009Dto, UpdateTABLE5009Dto, int>
{
    public TABLE5009Controller(ITABLE5009Service service)
        : base(service, "TABLE5009", "NCOMERLINE", new[] { "NCOMERLINE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
