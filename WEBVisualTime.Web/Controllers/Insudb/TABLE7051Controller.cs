using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7051;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7051Controller : CatalogController<TABLE7051Dto, CreateTABLE7051Dto, UpdateTABLE7051Dto, long>
{
    public TABLE7051Controller(ITABLE7051Service service)
        : base(service, "TABLE7051", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
