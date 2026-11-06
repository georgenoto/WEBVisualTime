using WEBVisualTime.Servicios.Insudb.DTOs.TABLE245;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE245Controller : CatalogController<TABLE245Dto, CreateTABLE245Dto, UpdateTABLE245Dto, long>
{
    public TABLE245Controller(ITABLE245Service service)
        : base(service, "TABLE245", "NTYPELOAN", new[] { "NTYPELOAN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
