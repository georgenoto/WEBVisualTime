using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5535;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5535Controller : CatalogController<TABLE5535Dto, CreateTABLE5535Dto, UpdateTABLE5535Dto, int>
{
    public TABLE5535Controller(ITABLE5535Service service)
        : base(service, "TABLE5535", "NDAMAGE_MAGNIF", new[] { "NDAMAGE_MAGNIF", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
