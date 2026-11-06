using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5523Controller : CatalogController<TABLE5523Dto, CreateTABLE5523Dto, UpdateTABLE5523Dto, int>
{
    public TABLE5523Controller(ITABLE5523Service service)
        : base(service, "TABLE5523", "NHEALTH_ORG", new[] { "NHEALTH_ORG", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
