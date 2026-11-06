using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8007Controller : CatalogController<TABLE8007Dto, CreateTABLE8007Dto, UpdateTABLE8007Dto, int>
{
    public TABLE8007Controller(ITABLE8007Service service)
        : base(service, "TABLE8007", "NAFECBASADI", new[] { "NAFECBASADI", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
