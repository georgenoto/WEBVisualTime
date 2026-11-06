using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5621;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5621Controller : CatalogController<TABLE5621Dto, CreateTABLE5621Dto, UpdateTABLE5621Dto, int>
{
    public TABLE5621Controller(ITABLE5621Service service)
        : base(service, "TABLE5621", "NTODAYSDEPOSIT", new[] { "NTODAYSDEPOSIT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
