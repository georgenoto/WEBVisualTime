using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8101;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8101Controller : CatalogController<TABLE8101Dto, CreateTABLE8101Dto, UpdateTABLE8101Dto, int>
{
    public TABLE8101Controller(ITABLE8101Service service)
        : base(service, "TABLE8101", "NAPLY", new[] { "NAPLY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
