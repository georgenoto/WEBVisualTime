using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE2Controller : CatalogController<TABLE2Dto, CreateTABLE2Dto, UpdateTABLE2Dto, long>
{
    public TABLE2Controller(ITABLE2Service service)
        : base(service, "TABLE2", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
