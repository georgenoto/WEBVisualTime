using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5585;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5585Controller : CatalogController<TABLE5585Dto, CreateTABLE5585Dto, UpdateTABLE5585Dto, int>
{
    public TABLE5585Controller(ITABLE5585Service service)
        : base(service, "TABLE5585", "NTYPEMOV", new[] { "NTYPEMOV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
