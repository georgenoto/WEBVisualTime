using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5540;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5540Controller : CatalogController<TABLE5540Dto, CreateTABLE5540Dto, UpdateTABLE5540Dto, int>
{
    public TABLE5540Controller(ITABLE5540Service service)
        : base(service, "TABLE5540", "NSECTOR_TYPE", new[] { "NSECTOR_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
