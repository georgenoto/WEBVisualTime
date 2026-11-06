using WEBVisualTime.Servicios.Insudb.DTOs.TABLE2000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE2000Controller : CatalogController<TABLE2000Dto, CreateTABLE2000Dto, UpdateTABLE2000Dto, long>
{
    public TABLE2000Controller(ITABLE2000Service service)
        : base(service, "TABLE2000", "NAPLY", new[] { "NAPLY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
