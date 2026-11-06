using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8001Controller : CatalogController<TABLE8001Dto, CreateTABLE8001Dto, UpdateTABLE8001Dto, int>
{
    public TABLE8001Controller(ITABLE8001Service service)
        : base(service, "TABLE8001", "NGUARSAV_STAT", new[] { "NGUARSAV_STAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
