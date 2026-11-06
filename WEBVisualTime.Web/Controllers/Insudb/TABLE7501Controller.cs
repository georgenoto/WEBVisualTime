using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7501;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7501Controller : CatalogController<TABLE7501Dto, CreateTABLE7501Dto, UpdateTABLE7501Dto, long>
{
    public TABLE7501Controller(ITABLE7501Service service)
        : base(service, "TABLE7501", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
