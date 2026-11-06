using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5706;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5706Controller : CatalogController<TABLE5706Dto, CreateTABLE5706Dto, UpdateTABLE5706Dto, int>
{
    public TABLE5706Controller(ITABLE5706Service service)
        : base(service, "TABLE5706", "NTABLE", new[] { "NTABLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
