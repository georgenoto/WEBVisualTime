using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5608;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5608Controller : CatalogController<TABLE5608Dto, CreateTABLE5608Dto, UpdateTABLE5608Dto, int>
{
    public TABLE5608Controller(ITABLE5608Service service)
        : base(service, "TABLE5608", "NSOURCE", new[] { "NSOURCE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
