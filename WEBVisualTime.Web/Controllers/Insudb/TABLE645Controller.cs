using WEBVisualTime.Servicios.Insudb.DTOs.TABLE645;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE645Controller : CatalogController<TABLE645Dto, CreateTABLE645Dto, UpdateTABLE645Dto, long>
{
    public TABLE645Controller(ITABLE645Service service)
        : base(service, "TABLE645", "NCODIGINT", new[] { "NCODIGINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
