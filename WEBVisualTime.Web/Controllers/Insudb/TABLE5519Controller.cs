using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5519;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5519Controller : CatalogController<TABLE5519Dto, CreateTABLE5519Dto, UpdateTABLE5519Dto, int>
{
    public TABLE5519Controller(ITABLE5519Service service)
        : base(service, "TABLE5519", "NOPTION", new[] { "NOPTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
