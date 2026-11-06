using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5598;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5598Controller : CatalogController<TABLE5598Dto, CreateTABLE5598Dto, UpdateTABLE5598Dto, int>
{
    public TABLE5598Controller(ITABLE5598Service service)
        : base(service, "TABLE5598", "NACTIONCOV", new[] { "NACTIONCOV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
