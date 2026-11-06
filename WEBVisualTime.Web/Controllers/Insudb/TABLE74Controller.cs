using WEBVisualTime.Servicios.Insudb.DTOs.TABLE74;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE74Controller : CatalogController<TABLE74Dto, CreateTABLE74Dto, UpdateTABLE74Dto, long>
{
    public TABLE74Controller(ITABLE74Service service)
        : base(service, "TABLE74", "NPAYINTER", new[] { "NPAYINTER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
