using WEBVisualTime.Servicios.Insudb.DTOs.TABLE254;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE254Controller : CatalogController<TABLE254Dto, CreateTABLE254Dto, UpdateTABLE254Dto, long>
{
    public TABLE254Controller(ITABLE254Service service)
        : base(service, "TABLE254", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
