using WEBVisualTime.Servicios.Insudb.DTOs.TABLE259;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE259Controller : CatalogController<TABLE259Dto, CreateTABLE259Dto, UpdateTABLE259Dto, long>
{
    public TABLE259Controller(ITABLE259Service service)
        : base(service, "TABLE259", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
