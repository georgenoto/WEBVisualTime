using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5611;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5611Controller : CatalogController<TABLE5611Dto, CreateTABLE5611Dto, UpdateTABLE5611Dto, int>
{
    public TABLE5611Controller(ITABLE5611Service service)
        : base(service, "TABLE5611", "NCON_EARTHQUAKE", new[] { "NCON_EARTHQUAKE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
