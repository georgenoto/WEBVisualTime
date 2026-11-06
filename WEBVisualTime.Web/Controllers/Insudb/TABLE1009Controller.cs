using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1009;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1009Controller : CatalogController<TABLE1009Dto, CreateTABLE1009Dto, UpdateTABLE1009Dto, long>
{
    public TABLE1009Controller(ITABLE1009Service service)
        : base(service, "TABLE1009", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
