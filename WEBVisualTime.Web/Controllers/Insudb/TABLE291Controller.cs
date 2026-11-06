using WEBVisualTime.Servicios.Insudb.DTOs.TABLE291;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE291Controller : CatalogController<TABLE291Dto, CreateTABLE291Dto, UpdateTABLE291Dto, string>
{
    public TABLE291Controller(ITABLE291Service service)
        : base(service, "TABLE291", "STYPE_ASSIG", new[] { "STYPE_ASSIG", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
