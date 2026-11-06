using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5543;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5543Controller : CatalogController<TABLE5543Dto, CreateTABLE5543Dto, UpdateTABLE5543Dto, int>
{
    public TABLE5543Controller(ITABLE5543Service service)
        : base(service, "TABLE5543", "NPROTEC_TYPE", new[] { "NPROTEC_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
