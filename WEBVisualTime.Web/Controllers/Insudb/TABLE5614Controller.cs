using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5614;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5614Controller : CatalogController<TABLE5614Dto, CreateTABLE5614Dto, UpdateTABLE5614Dto, int>
{
    public TABLE5614Controller(ITABLE5614Service service)
        : base(service, "TABLE5614", "NINUNDAT", new[] { "NINUNDAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
