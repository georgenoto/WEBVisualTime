using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5635;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5635Controller : CatalogController<TABLE5635Dto, CreateTABLE5635Dto, UpdateTABLE5635Dto, int>
{
    public TABLE5635Controller(ITABLE5635Service service)
        : base(service, "TABLE5635", "NSURR_REASON", new[] { "NSURR_REASON", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
