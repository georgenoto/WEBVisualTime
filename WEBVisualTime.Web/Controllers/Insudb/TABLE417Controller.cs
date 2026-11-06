using WEBVisualTime.Servicios.Insudb.DTOs.TABLE417;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE417Controller : CatalogController<TABLE417Dto, CreateTABLE417Dto, UpdateTABLE417Dto, long>
{
    public TABLE417Controller(ITABLE417Service service)
        : base(service, "TABLE417", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
