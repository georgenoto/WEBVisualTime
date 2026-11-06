using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5501;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5501Controller : CatalogController<TABLE5501Dto, CreateTABLE5501Dto, UpdateTABLE5501Dto, int>
{
    public TABLE5501Controller(ITABLE5501Service service)
        : base(service, "TABLE5501", "NLEGAL_SCH", new[] { "NLEGAL_SCH", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
