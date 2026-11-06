using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5600;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5600Controller : CatalogController<TABLE5600Dto, CreateTABLE5600Dto, UpdateTABLE5600Dto, int>
{
    public TABLE5600Controller(ITABLE5600Service service)
        : base(service, "TABLE5600", "NINDRECDEP", new[] { "NINDRECDEP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
