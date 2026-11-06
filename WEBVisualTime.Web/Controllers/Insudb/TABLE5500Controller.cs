using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5500;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5500Controller : CatalogController<TABLE5500Dto, CreateTABLE5500Dto, UpdateTABLE5500Dto, int>
{
    public TABLE5500Controller(ITABLE5500Service service)
        : base(service, "TABLE5500", "NSCHE_CODE", new[] { "NSCHE_CODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
