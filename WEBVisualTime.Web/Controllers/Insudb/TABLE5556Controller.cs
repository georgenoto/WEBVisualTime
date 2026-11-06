using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5556Controller : CatalogController<TABLE5556Dto, CreateTABLE5556Dto, UpdateTABLE5556Dto, int>
{
    public TABLE5556Controller(ITABLE5556Service service)
        : base(service, "TABLE5556", "NOFFICEAGEN", new[] { "NOFFICEAGEN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
