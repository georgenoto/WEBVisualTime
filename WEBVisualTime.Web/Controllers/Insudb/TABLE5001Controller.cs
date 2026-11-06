using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5001Controller : CatalogController<TABLE5001Dto, CreateTABLE5001Dto, UpdateTABLE5001Dto, int>
{
    public TABLE5001Controller(ITABLE5001Service service)
        : base(service, "TABLE5001", "NINSUR_AREA", new[] { "NINSUR_AREA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
