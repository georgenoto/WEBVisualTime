using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5744;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5744Controller : CatalogController<TABLE5744Dto, CreateTABLE5744Dto, UpdateTABLE5744Dto, int>
{
    public TABLE5744Controller(ITABLE5744Service service)
        : base(service, "TABLE5744", "NFUNDS_ORIGIN", new[] { "NFUNDS_ORIGIN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
