using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5712;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5712Controller : CatalogController<TABLE5712Dto, CreateTABLE5712Dto, UpdateTABLE5712Dto, int>
{
    public TABLE5712Controller(ITABLE5712Service service)
        : base(service, "TABLE5712", "NCAUSE", new[] { "NCAUSE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
