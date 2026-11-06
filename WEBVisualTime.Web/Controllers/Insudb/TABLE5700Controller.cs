using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5700;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5700Controller : CatalogController<TABLE5700Dto, CreateTABLE5700Dto, UpdateTABLE5700Dto, int>
{
    public TABLE5700Controller(ITABLE5700Service service)
        : base(service, "TABLE5700", "NOPERTYPE", new[] { "NOPERTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
