using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5521;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5521Controller : CatalogController<TABLE5521Dto, CreateTABLE5521Dto, UpdateTABLE5521Dto, int>
{
    public TABLE5521Controller(ITABLE5521Service service)
        : base(service, "TABLE5521", "NLIMITDRIV", new[] { "NLIMITDRIV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
