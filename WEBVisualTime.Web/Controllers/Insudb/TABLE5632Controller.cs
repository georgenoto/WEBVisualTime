using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5632;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5632Controller : CatalogController<TABLE5632Dto, CreateTABLE5632Dto, UpdateTABLE5632Dto, string>
{
    public TABLE5632Controller(ITABLE5632Service service)
        : base(service, "TABLE5632", "SCERTYPE", new[] { "SCERTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
